using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
   public class computer
    {
       public neicun Disk { get; set; }
       public void read() {
           Disk.read();
       }
       public override string ToString()
       {
           return base.ToString();
       }
       public void write()
       {
           try
           {

           }
           catch (NullReferenceException e)
           {
               //只能处理空引用异常
               throw e;
           }
           Disk.write();
       }
      
    }
}
