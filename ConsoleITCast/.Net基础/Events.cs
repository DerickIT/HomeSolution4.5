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
         * 委托是个数据类型
         * 创建事件，不确定有什么操作，使用事件
         * 事件就是一种委托，完全可以用委托代替，但是委托必须在外部被“使用”，用事件就会更符合案例
         * 
         * 通过委托实现事件的问题：在外部可以触发，因为委托变量的访问修饰符是public，所以在外部任何地方都可以触发
         * 如果吧委托的访问修饰符改为private，那么不能在外部触发，，也不能在外部赋值了
         * 
         * 事件只能使用+=、-=赋值，所以避免了使用=赋值时的覆盖问题
         * 事件只能在定义的类中使用，避免了在外部被“滥用”的危险
         * 事件其实就是一个私有的委托和两个公有的add,remove方法，只能通过+=-=赋值
         */
       
 public delegate void methoddelegate(int wd);
        public event methoddelegate methodevent;
        public void guolu()
        { 
           
            int shuiwen = 0;
           
            for (int i = 0; i < 100; i++)
            {
                if (i >= 95 && methodevent != null)
                {
                    shuiwen = i;
                    methodevent(shuiwen);
                }
            }
        }

    }
}
