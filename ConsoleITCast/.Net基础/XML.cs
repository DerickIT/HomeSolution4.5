using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace ConsoleITCast.Net基础
{
    public class XML
    {
        public int age { get; set; }
        /*
         * XML与HTML的区别：
         * xml元素必须关闭
         * xml中元素的属性值必须用引号
         * xml大小写敏感（casesensitive）
         * 验证xml规范的html叫做“符合xhtml标准”开发的网站必须通过w3c标准
         * 优点：容易读懂，格式标准任何语言都内置了xml分析引擎，不用单独进行稳健分析引擎的编写
         * xml就是用一种格式化的方式来存储数据，并且是文本文件任何时候我们都能很容仪的用记事本打开，
         * 搜索时可以使用xmldocument的selectnodes搜索某个节点
         * schema约束xml能写哪些节点   xsd格式文件
         * dtd同schema都是用来约束xml格式
         */
        public void xmltest()
        {
            XElement xl = new XElement("");
            xl.Add("");//创建节点添加值
            XDocument xd = XDocument.Load("");//加载路径的xml文件
            var xls = xd.Root;//获取根节点
            xd.Element("读取这个节点内容");
            XmlDocument xdo = new XmlDocument();
            XmlNodeList xnl = xdo.SelectNodes("xpath表达式");//直接查找当前表达式的符合内容

        }

        void write()
        {
            XDocument xd = new XDocument();//创建一个xml对象
            XElement xle = new XElement("根节点");//创建一个根节点
            xd.Add(xle);//将节点添加到文档

            //为文档添加属性
            XAttribute attr = new XAttribute("url", "www.baidu.com");//采用键值对形式添加xml元素属性
            xd.Root.Add(attr);//将百度元素属性添加到文档
            //xd.Root.SetAttributeValue("设置键", "设置值");

            xle.SetAttributeValue("key", "value");
            xd.Root.Add(xle);
            xd.Save("存储路径");//存储路径,只有一个元素也可以保存，xelement
        }
        void Diguixmlread(XElement xl, string ss)
        {
            // xl.Element
            foreach (var item in xl.Elements())
            {
                Console.WriteLine(item.Name);

                string ssd = item.Name.ToString();
                Diguixmlread(xl, ssd);//使用递归将读取到的xml节点输出
                //---------------------
                item.Attribute("id");//获取id
            }
        }

        /// <summary>
        /// 隐式类型转换
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static implicit operator XML(int a)
        {
            return new XML() { age = a };
        }
    }
}
