using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    public static class X深拷贝与浅复制
    {
        /*
         * 两种都对对象进行了复制，深拷贝相当于是重新创建了一个对象，浅复制只是复制了地址，重新开辟了空间
         */

        public void sdf()
        {
            //浅复制
            ptest qian = new ptest();
            qian.Age = 13;
            qian.name = "zhn";
            ptest qiant = new ptest();
            qiant.Age = qian.Age;
        }
        public void shen()
        {
            ptest shen = new ptest();
            shen.Age = 13;
            shen.name = "zhn";
            ptest shens = new ptest();
            shens.Age = shen.Age;
            shens.name = shen.name;

            //深拷贝
            ptest shenss = shens;
        }


    }
    public class ptest
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string name { get; set; }
    }
}
