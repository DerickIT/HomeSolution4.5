using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    /*
     * 委托是个参数类型
     * 委托的作用;可以在某个代码内部注入一段外部代码
     */
    public class delegates
    {
        public delegate void str(string val);
        public void strs(string a)
        {

        }
        public void testdelegate(str d)
        {
            d.Invoke("s");

        }
    }
}
