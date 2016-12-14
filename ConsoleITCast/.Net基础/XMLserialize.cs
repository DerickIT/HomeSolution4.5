using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace ConsoleITCast.Net基础
{
    class XMLserialize
    {
        /**
         *xml序列化 
         *获取xml节点
         *创建xml文档
         *添加
         *反射属性判断有没有标记不被序列化
         *遍历所有属性添加到xml文档
         *写入到文件中
         */

        public void xmlserialize(string xml)
        {
            XmlSerializer ss = new XmlSerializer(typeof(int));

            using (FileStream fs = File.OpenWrite("path"))
            {
                ss.Serialize(fs, xml);
                
            }
        }
    }
}
