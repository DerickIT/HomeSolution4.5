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
         * 通过委托实现事件的问题：在外部可以触发，因为委托变量的访问修饰符是public，所以在外部任何地方都可以触发
         * 如果吧委托的访问修饰符改为private，那么不能在外部触发，，也不能在外部赋值了
         */
        public delegate void methoddelegate(int wd);
        public event methoddelegate methodevent;

        public void guolu(methoddelegate md)
        {
            int shuiwen = 0;
            methoddelegate _event = md;
            for (int i = 0; i < 100; i++)
            {
                if (i >= 95 && _event != null)
                {
                    shuiwen = i;
                    _event(shuiwen);
                }
            }
        }

    }
}
