using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    /*
     * 委托是个参数类型
     * 委托的作用;可以在某个代码内部注入一段外部代码
     * 委托是引用类型，会编译成一个class
     * 通过委托打破了访问修饰符的限制，无论之前是static或者private，只要传入到delegate中就能访问到
     * 访问修饰符是为了变成方便，多态，其实还是可以通过委托，反射访问到
     * ******
     * 多播委托中要是有返回值，只会得到最后一个返回结果的方法
     */
    public class delegates
    {
        public delegate void str(string val);
        public  void strs(string a)
        {
           str ss= (string s)=>Console.WriteLine("sd");
           ss += (string sc) => Console.WriteLine("sddc"); //多播委托
        }
       
        public void testdelegate(str d)
        {
            d.Invoke("s");
           
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public void sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 匿名方法：lambda表达式本质就是匿名委托
        /// </summary>
        str sf = delegate(string a)
        {
            Console.WriteLine(a);
        };
    }
}
