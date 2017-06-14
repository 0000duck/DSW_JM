using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DSMS.DSW.Control.BLL
{
    public class LogManager
    {
        private static string logPath = string.Empty;
        /// <summary>
        /// 保存日志的文件夹
        /// </summary>
        public static string LogPath
        {
            get
            {
                if (logPath == string.Empty)
                {
                    logPath = AppDomain.CurrentDomain.BaseDirectory + @"Log\";

                    if (!Directory.Exists(logPath))
                    {
                        Directory.CreateDirectory(logPath);
                    }
                }
                return logPath;
            }
            set
            {
                logPath = value;
            }
        }
        private static string logFilePrefix = string.Empty;
        /// <summary>
        /// 日志文件前缀
        /// </summary>
        public static string LogFilePrefix
        {
            get { return logFilePrefix; }
            set { logFilePrefix = value; }
        }
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logFile"></param>
        /// <param name="msg"></param>
        public static void WriteLog(string logFile, string msg)
        {
            try
            {
                System.IO.StreamWriter sw = System.IO.File.AppendText(LogPath + LogFilePrefix + logFile + " " + DateTime.Now.ToString("yyyyMMdd") + ".Log");
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:") + msg);
                sw.Close();
            }
            catch { }
        }
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logFile"></param>
        /// <param name="msg"></param>
        public static void WriteLog(LogFile logFile, string msg)
        {
            WriteLog(logFile.ToString(), msg);
        }
        /// <summary>
        /// 日志类型
        /// </summary>
        public enum LogFile
        {
            Trace, Warning, Error, SQL
        }

    }
}
