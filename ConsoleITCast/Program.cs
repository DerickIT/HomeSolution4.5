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
            object.ReferenceEquals(m3, m3);
            int num = 0;
            var sub = 0;
           var bo= num.Equals(sub);

        }
        public int add(params int[] arr)
        {
            int num = 0;
            var sub = 0;
            num.Equals(sub);
            for (int i = 0; i < arr.Length; i++)
            {//如果有其他参数，可变参数必须放到最后一个
                num += arr[i];
            }
            WeakReference wr = new WeakReference(sub);
           object a= wr.Target;
            GC.Collect();//强制进行垃圾回收，从第0代开始回收，还一直用的时候到第1代，下次再检测时如果还用就会升到第2代，幸存者会往上升级，第一代第n代只有满了才会回收，不然只是回收第0代
            return num;
        }
    }


}
