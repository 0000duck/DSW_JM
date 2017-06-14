using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using OPCHelper;

namespace OPCHelper
{
   public class XmlHelper
    {

       public readonly string FilePath = Application.StartupPath + @"\XML\Tag.XMl";
         
        //添加用户
       public void AddTag(string Name, string Address)
        {
            XmlDocument   xmldoc = new XmlDocument();
            xmldoc.Load(FilePath);
            XmlNode root = xmldoc.SelectSingleNode("Root");
            XmlElement  xmlelem = xmldoc.CreateElement("Tag");
            root.AppendChild(xmlelem);
            xmlelem.SetAttribute("Name", Name);//设置该节点属性 
            xmlelem.SetAttribute("Address", Address);//设置该节点属性 
            xmlelem.SetAttribute("Value", "");//设置该节点属性 
            xmlelem.SetAttribute("SetValue", "");//设置该节点属性 
            xmldoc.Save(FilePath);
       }

       public void DeleteTag(string Address)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(FilePath);
            XmlNodeList list = xmldoc.SelectSingleNode("Root").ChildNodes;

            foreach (XmlElement var in list)
            {
                XmlElement xmle = (XmlElement)var;
                if (xmle.GetAttribute("Address") == Address)
                {
                    xmle.ParentNode.RemoveChild(xmle);
                    xmldoc.Save(FilePath);
                }
            }
        
        }
    }
}
