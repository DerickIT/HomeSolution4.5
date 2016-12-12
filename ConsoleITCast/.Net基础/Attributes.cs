using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{

    public class Attributes
    {
        [Objeces("人员id")]
        public int ID { get; set; }
    }
    public class ObjecesAttribute : Attribute//本身继承attribute没有什么意义，只是相当于做了一个标记，需要实现
    {
        public ObjecesAttribute(string a)
        {
            this.len = a;
        }
        public string len { get; set; }
    }
    public class funccs
    {

        public void func()
        {
            object o = new Attributes();
            Type _type = o.GetType();
            PropertyInfo[] pi = _type.GetProperties();
            foreach (var item in pi)
            {
                object[] obj = item.GetCustomAttributes(typeof(Attributes), false);
                if (obj.Length > 0)
                {
                    Attributes sdf = (Attributes)obj[0];
                }
            }

        }
    }
}
