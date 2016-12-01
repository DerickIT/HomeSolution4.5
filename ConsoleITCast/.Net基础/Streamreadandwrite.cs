using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Streamreadandwrite
    {
        public void test()
        {
            using (StreamReader sr = new StreamReader())
            {
                if (sr.EndOfStream)
                {
                    //读取到最后一行
                }
                using (StreamWriter sw=new StreamWriter ("lujing"))
                {
                    
                }
            }
        }
    }
}
