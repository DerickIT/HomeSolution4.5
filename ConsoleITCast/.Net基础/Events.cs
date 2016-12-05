using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
   public class Events
    {
       /*
        * 创建事件，不确定有什么操作，使用事件
        * 事件就是一种委托，完全可以用委托代替，但是委托必须在外部被“使用”，用事件就会更符合案例
        * 
        */
       public delegate void methoddelegate();
       public event methoddelegate methodevent;

    }
}
