using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Assemlys
    {
        /*
         * dll与exe区别是exe有入口代码，可以被执行
         * 元数据 
         * 程序集元数据：程序集的基本信息包含{
         * 类型元数据，多少个类，多少个字段}
         * MSIL代码
         * 读取程序集中的类，字段，成员类型成为反射
         * 
         */

        public void test()
        {
            Assembly ab = Assembly.LoadFile("");//加载程序集
            ab.GetType();//获取所有类型
            ab.GetExportedTypes();//获取所有的访问修饰符为public 的类型
        }
    }
}
