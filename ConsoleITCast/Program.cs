using ConsoleITCast.Net基础;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast
{
    class Program
    {
        static void Main(string[] args)
        {
            computer com = new computer();
            com.Disk = new mp3();
            com.read();
            var m3 = new mp3();
            m3.player();
            var sd = new sdf();
            sd.dd();
        }
    }

    class person
    {
        public  void dd() { Console.WriteLine("p-----"); }
    }
    class sdf : person
    {
        
        public  void dd() { 
            base.dd();
            Console.WriteLine("s------"); }
    }
}
