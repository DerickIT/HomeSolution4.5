using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleITCast.Net基础
{
    public class XML
    {
        /*
         * XML与HTML的却别
         * xml元素必须关闭
         * xml中元素的属性值必须用引号
         * xml大小写敏感（casesensitive）
         * 验证xml规范的html叫做“符合xhtml标准”开发的网站必须通过w3c标准
         * 优点：容易读懂，格式标准任何语言都内置了xml分析引擎，不用单独进行稳健分析引擎的编写
         * xml就是用一种格式化的方式来存储数据，并且是文本文件任何时候我们都能很容仪的用记事本打开，
         */
        public void xmltest()
        {
            XElement xl = new XElement("");
            xl.Add("");
        }
    }
}
