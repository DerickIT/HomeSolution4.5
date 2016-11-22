using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    public class index__
    {
        private string[] name = new string[] { "zhn", "2", "3", "4", "5" };
        public string this[int index]
        { get { return name[index]; } set { name[index] = value; } }
        public void method(states s)
        {
           s= states.离线;
        }
        
    }
}
