using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    public class mp3 : neicun
    {
        public override void read()
        {
            Console.WriteLine("mp3实现内存的读方法");
        }

        public override void write()
        {
            Console.WriteLine("mp3实现内存的写方法");
        }
        public void player()
        {
            Stopwatch starttime = new Stopwatch();
            starttime.Start();
            Console.WriteLine("实现自己的播放方法");
            starttime.Stop();//结束计时
        }
    }
}
