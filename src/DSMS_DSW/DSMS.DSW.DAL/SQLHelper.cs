using System; 
using System.Configuration; 
using System.Data; 
using System.Data.SqlClient; 
using System.Collections;
using System.Text;

namespace DSMS.DSW.DAL
{ 
	/// <summary> 
	/// ͨ�����ݿ��� 
	/// </summary> 
	public class SQLHelper
	{

        private static readonly string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["Simple.Data.Properties.Settings.DefaultConnectionString"].ToString();
      
        //public DataAccess(int d) 
        //{ 
        //    //ConnStr = ConfigurationSettings.AppSettings["connect"];
        //    if (d == 1)
        //    {
        //        ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();
        //    }
        //    if (d == 2)
        //    {
        //        ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["EDOC2V4"].ToString();
        //    }
        //    if (d == 3)
        //    {
        //        ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["Default2"].ToString();
        //    }

        //    if (d == 4)
        //    {
        //        ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["UltimusDB"].ToString();
        //    }
        //} 
        //public DataAccess(string Str) 
        //{ 
        //    try 
        //    { 
        //        this.ConnStr = Str; 

        //    } 
        //    catch(Exception ex) 
        //    { 
        //        throw ex; 
        //    } 
        //} 

		/// <summary> 
		/// ����connection���� 
		/// </summary> 
		/// <returns></returns> 
        public static SqlConnection ReturnConn() 
		{ 
			SqlConnection Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			return Conn; 
		}
        public static void Dispose(SqlConnection Conn) 
		{ 
			if(Conn!=null) 
			{ 
				Conn.Close(); 
				Conn.Dispose(); 
			} 
			GC.Collect(); 
		} 
		/// <summary> 
		/// ����SQL��� 
		/// </summary> 
		/// <param name="SQL"></param> 
		public static void RunProc(string SQL) 
		{ 
			SqlConnection Conn;
            
			Conn = new SqlConnection(ConnStr); 
			Conn.Open();
            try
            {
			SqlCommand Cmd ; 
			Cmd = CreateCmd(SQL, Conn); 
			 
			Cmd.ExecuteNonQuery(); 
			} 
			catch 
			{ 
				throw new Exception(SQL); 
			} 
			Dispose(Conn); 
			return; 
		} 

		/// <summary> 
		/// ����SQL��䷵��DataReader 
		/// </summary> 
		/// <param name="SQL"></param> 
		/// <returns>SqlDataReader����.</returns> 
        public static SqlDataReader RunProcGetReader(string SQL) 
		{ 
			SqlConnection Conn;
         
            Conn = new SqlConnection(ConnStr); 
			Conn.Open();
            try
            {
                SqlCommand Cmd;
                Cmd = CreateCmd(SQL, Conn);
                SqlDataReader Dr;

                Dr = Cmd.ExecuteReader(CommandBehavior.Default);
                return Dr;
            }
            catch
            {
                throw new Exception(SQL);
            }
            finally
            {
                Dispose(Conn);
            }
		} 

		/// <summary> 
		/// ����Command���� 
		/// </summary> 
		/// <param name="SQL"></param> 
		/// <param name="Conn"></param> 
		/// <returns></returns> 
        public static SqlCommand CreateCmd(string SQL, SqlConnection Conn) 
		{ 
			SqlCommand Cmd ; 
			Cmd = new SqlCommand(SQL, Conn); 
			return Cmd; 
		} 

		/// <summary> 
		/// ����Command���� 
		/// </summary> 
		/// <param name="SQL"></param> 
		/// <returns></returns> 
        public static SqlCommand CreateCmd(string SQL) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			SqlCommand Cmd ; 
			Cmd = new SqlCommand(SQL, Conn); 
			return Cmd; 
		} 

		/// <summary> 
		/// ����adapter���� 
		/// </summary> 
		/// <param name="SQL"></param> 
		/// <param name="Conn"></param> 
		/// <returns></returns> 
        public static SqlDataAdapter CreateDa(string SQL) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			SqlDataAdapter Da; 
			Da = new SqlDataAdapter(SQL, Conn); 
			return Da; 
		} 

		/// <summary> 
		/// ����SQL���,����DataSet���� 
		/// </summary> 
		/// <param name="procName">SQL���</param> 
		/// <param name="prams">DataSet����</param> 
        public static DataSet RunProc(string SQL, DataSet Ds) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr);
            
            Conn.Open(); 
			SqlDataAdapter Da;
            try
            { 
			//Da = CreateDa(SQL, Conn); 
			Da = new SqlDataAdapter(SQL,Conn); 
			
				Da.Fill(Ds); 
			} 
			catch(Exception Err) 
			{ 
				throw Err; 
			} 
			Dispose(Conn); 
			return Ds; 
		} 

		/// <summary> 
		/// ����SQL���,����DataSet���� 
		/// </summary> 
		/// <param name="procName">SQL���</param> 
		/// <param name="prams">DataSet����</param> 
		/// <param name="dataReader">����</param> 
        public static DataSet RunProc(string SQL, DataSet Ds, string tablename) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			SqlDataAdapter Da; 
			Da = CreateDa(SQL); 
			try 
			{ 
				Da.Fill(Ds,tablename); 
			} 
			catch(Exception Ex) 
			{ 
				throw Ex; 
			} 
			Dispose(Conn); 
			return Ds; 
		}

        /// <summary> 
        /// ����SQL���,����DataTable���� 
        /// </summary> 
        /// <param name="procName">SQL���</param> 
        public static DataTable RunProcToDataTable(string SQL)
        {
           
            SqlConnection Conn;
            DataSet ds = new DataSet();
          
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            try
            {
            SqlDataAdapter Da;
          
            //Da = CreateDa(SQL, Conn); 
            Da = new SqlDataAdapter(SQL, Conn);
            
                Da.Fill(ds);
             
            }
            catch (Exception Err)
            {
                throw Err;
            }
            
            Dispose(Conn);
            return ds.Tables[0];
        }


        public static DataTable RunProcToDataTable(string SQL, SqlParameter[] prams)
        {
            DataSet ds = new DataSet();
            try
            {
            SqlCommand Cmd = CreateSQLCmd(SQL, prams);
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                Da.Fill(ds);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return ds.Tables[0];
        } 

		/// <summary> 
		/// ����SQL���,����DataSet���� 
		/// </summary> 
		/// <param name="procName">SQL���</param> 
		/// <param name="prams">DataSet����</param> 
		/// <param name="dataReader">����</param> 
        public static DataSet RunProc(string SQL, DataSet Ds, int StartIndex, int PageSize, string tablename) 
		{
           
			SqlConnection Conn;
           
			Conn = new SqlConnection(ConnStr); 
			Conn.Open();
            try
            { 
			SqlDataAdapter Da ; 
			Da = CreateDa(SQL); 
			Da.Fill(Ds, StartIndex, PageSize, tablename); 
			} 
			catch(Exception Ex) 
			{ 
				throw Ex; 
			} 
			Dispose(Conn); 
			return Ds; 
		} 

		/// <summary> 
		/// �����Ƿ�������� 
		/// </summary> 
		/// <returns></returns> 
        public static bool ExistData(string SQL) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			SqlDataReader Dr ; 
			Dr = CreateCmd(SQL,Conn).ExecuteReader(); 
			if (Dr.Read()) 
			{ 
				Dispose(Conn); 
				return true; 
			} 
			else 
			{ 
				Dispose(Conn); 
				return false; 
			} 
		} 

		/// <summary> 
		/// ����SQL���ִ�н���ĵ�һ�е�һ�� 
		/// </summary> 
		/// <returns>�ַ���</returns> 
        public static string ReturnValue(string SQL) 
		{
           
			SqlConnection Conn;
           
		
			string result; 
			SqlDataReader Dr ;
           
                Conn = new SqlConnection(ConnStr);
                Conn.Open();
                try
                {
				Dr = CreateCmd(SQL,Conn).ExecuteReader(); 
				if (Dr.Read()) 
				{ 
					result = Dr[0].ToString(); 
					Dr.Close(); 
				} 
				else 
				{ 
					result = ""; 
					Dr.Close(); 
				} 
			} 
			catch 
			{ 
				throw new Exception(SQL); 
			} 
			Dispose(Conn); 
			return result; 
		} 

		/// <summary> 
		/// ����SQL����һ��,��ColumnI��, 
		/// </summary> 
		/// <returns>�ַ���</returns> 
        public static string ReturnValue(string SQL, int ColumnI) 
		{
          
			SqlConnection Conn; 
			
			string result; 
			SqlDataReader Dr ;
           
                Conn = new SqlConnection(ConnStr);
                Conn.Open();
                try
                {
	    	Dr = CreateCmd(SQL,Conn).ExecuteReader(); 
			} 
			catch 
			{ 
				throw new Exception(SQL); 
			} 
			if (Dr.Read()) 
			{ 
				result = Dr[ColumnI].ToString(); 
			} 
			else 
			{ 
				result = ""; 
			} 
			Dr.Close(); 
			Dispose(Conn); 
			return result; 
		}

        /// <summary> 
        /// ����һ��sqlcommand. 
        /// </summary> 
        /// <param name="sql">sql���.</param> 
        /// <param name="prams">������.</param> 
        /// <returns>sqlcommand����.</returns> 
        public static SqlCommand CreateSQLCmd(string sql, SqlParameter[] prams)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            Cmd.CommandType = CommandType.Text;
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                {
                    if (parameter != null)
                    {
                        Cmd.Parameters.Add(parameter);
                    }
                }
            }
            return Cmd;
        } 

		/// <summary> 
		/// ����һ���洢����ʹ�õ�sqlcommand. 
		/// </summary> 
		/// <param name="procName">�洢������.</param> 
		/// <param name="prams">�洢�����������.</param> 
		/// <returns>sqlcommand����.</returns> 
        public static SqlCommand CreateCmd(string procName, SqlParameter[] prams) 
		{ 
			SqlConnection Conn; 
			Conn = new SqlConnection(ConnStr); 
			Conn.Open(); 
			SqlCommand Cmd = new SqlCommand(procName, Conn); 
			Cmd.CommandType = CommandType.StoredProcedure; 
			if (prams != null) 
			{ 
				foreach (SqlParameter parameter in prams) 
				{ 
					if(parameter != null) 
					{ 
						Cmd.Parameters.Add(parameter); 
					} 
				} 
			} 
			return Cmd; 
		}

        /// <summary> 
        /// Ϊ�洢��������һ��SqlCommand���� 
        /// </summary> 
        /// <param name="procName">�洢������</param> 
        /// <param name="prams">�洢���̲���</param> 
        /// <returns>SqlCommand����</returns> 
        private static SqlCommand CreateCmd(string procName, SqlParameter[] prams, SqlDataReader Dr)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlCommand Cmd = new SqlCommand(procName, Conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                    Cmd.Parameters.Add(parameter);
            }
            Cmd.Parameters.Add(
                new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                ParameterDirection.ReturnValue, false, 0, 0,
                string.Empty, DataRowVersion.Default, null));

            return Cmd;
        } 

		/// <summary> 
		/// ���д洢����,����. 
		/// </summary> 
		/// <param name="procName">�洢������</param> 
		/// <param name="prams">�洢���̲���</param> 
		/// <param name="dataReader">SqlDataReader����</param> 
        public static void RunProc(string procName, SqlParameter[] prams, SqlDataReader Dr) 
		{ 

			SqlCommand Cmd = CreateCmd(procName, prams, Dr); 
			Dr = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection); 
			return; 
		} 

		/// <summary> 
		/// ���д洢����,����. 
		/// </summary> 
		/// <param name="procName">�洢������</param> 
		/// <param name="prams">�洢���̲���</param> 
        public static string RunProc(string procName, SqlParameter[] prams) 
		{ 
			SqlDataReader Dr; 
			SqlCommand Cmd = CreateCmd(procName, prams); 
			Dr = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection); 
			if(Dr.Read()) 
			{ 
				return Dr.GetValue(0).ToString(); 
			} 
			else 
			{ 
				return ""; 
			} 
		}

        /// <summary> 
        /// ����sql,����. 
        /// </summary> 
        /// <param name="sql">sql���</param> 
        /// <param name="prams">�洢���̲���</param> 
        public static  string RunProcPrams(string sql, SqlParameter[] prams)
        {
            SqlDataReader Dr;
            SqlCommand Cmd = CreateSQLCmd(sql, prams);
            Dr = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (Dr.Read())
            {
                return Dr.GetValue(0).ToString();
            }
            else
            {
                return "";
            }
        } 

		/// <summary> 
		/// ���д洢����,����dataset. 
		/// </summary> 
		/// <param name="procName">�洢������.</param> 
		/// <param name="prams">�洢�����������.</param> 
		/// <returns>dataset����.</returns> 
        public static DataSet RunProc(string procName, SqlParameter[] prams, DataSet Ds) 
		{ 
			SqlCommand Cmd = CreateCmd(procName,prams); 
			SqlDataAdapter Da = new SqlDataAdapter(Cmd); 
			try 
			{ 
				Da.Fill(Ds); 
			} 
			catch(Exception Ex) 
			{ 
				throw Ex; 
			} 
			return Ds; 
		} 

		/// <summary> 
		/// ���д洢����,����dataset. 
		/// </summary> 
		/// <param name="procName">�洢������.</param> 
		/// <param name="prams">�洢�����������.</param> 
		/// <param name="prams">DataSet����</param> 
		/// <param name="dataReader">����</param> 
        public static DataSet RunProc(string procName, SqlParameter[] prams, DataSet Ds, string tablename) 
		{ 
			SqlCommand Cmd = CreateCmd(procName,prams); 
			SqlDataAdapter Da = new SqlDataAdapter(Cmd); 
			try 
			{ 
				Da.Fill(Ds,tablename); 
			} 
			catch(Exception Ex) 
			{ 
				throw Ex; 
			} 
			return Ds; 
		}


        /// <summary> 
        /// ���д洢����,����dataset. 
        /// </summary> 
        /// <param name="procName">�洢������.</param> 
        /// <param name="prams">�洢�����������.</param> 
        /// <param name="prams">DataSet����</param> 
        /// <param name="dataReader">����</param> 
        public static DataTable RunProcDataTable(string procName, SqlParameter[] prams)
        {
            SqlCommand Cmd = CreateCmd(procName, prams);
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable dt=new DataTable();
            try
            {
                Da.Fill(dt);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return dt;
        }


        #region ��ҳ
        /// <summary>
        /// ͨ�÷�ҳ
        /// </summary>
        /// <param name="Sql">������ɵ�SQL�ַ���</param>
        /// <param name="PageIndex">ҳ��</param>
        /// <param name="PageSize">ҳ��С</param>
        /// <param name="OrderBy">�����ֶ� ���� �� ID DESC </param> 
        /// <param name="Paras">������</param>
        /// <param name="TotalCount">�����ܼ�¼��</param>
        /// <returns>datatable</returns>
        public static DataTable CreateSqlByPageExcuteSql(string Sql, int PageIndex, int PageSize, string OrderBy, SqlParameter[] Paras, ref int TotalCount)
        {
            StringBuilder sbSql = new StringBuilder();
            if (PageIndex == 1)
                sbSql.Append("SELECT TOP " + PageSize + " *  FROM");
            else
                sbSql.Append("SELECT * FROM ");
            sbSql.Append(" ( SELECT ROW_NUMBER() OVER (ORDER BY " + OrderBy + ") as ���,tempTable.*");
            sbSql.Append(" FROM ( " + Sql + " ) AS  tempTable ) AS tmp ");

            if (PageIndex != 1)
                sbSql.Append("WHERE ��� BETWEEN CONVERT(varchar,(@PageIndex-1)*@PageSize+1) AND CONVERT(varchar,(@PageIndex-1)*@PageSize+@PageSize) ");

            sbSql.Append(" SELECT @TotalRecord=count(*) from (" + Sql + ") tempTable");

            /*���¹���SqlParameter*/
            int index = 0;
            int Length = 0;
            SqlParameter[] SqlParas;

            if (Paras != null && Paras.Length > 0)
            {
                Length = Paras.Length;
                SqlParas = new SqlParameter[Length + 3];
                for (int i = 0; i < Paras.Length; i++)
                {
                    SqlParas[i] = Paras[i];
                    index++;
                }
            }
            else
                SqlParas = new SqlParameter[Length + 3];



            /*����ҳ����׷����SqlParameter*/
            SqlParas[index] = new SqlParameter("@PageIndex", SqlDbType.Int);
            SqlParas[index].Value = PageIndex;
            index++;
            SqlParas[index] = new SqlParameter("@PageSize", SqlDbType.Int);
            SqlParas[index].Value = PageSize;
            index++;
            SqlParas[index] = new SqlParameter("@TotalRecord", SqlDbType.Int);
            SqlParas[index].Direction = ParameterDirection.Output;
            DataTable dtTemp = RunProcToDataTable(sbSql.ToString(), SqlParas);
            TotalCount = (int)SqlParas[index].Value;
            return dtTemp;
        }
        #endregion
	} 
} 
