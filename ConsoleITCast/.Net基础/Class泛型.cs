using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Class泛型<T,G> where T:class,new()
    {
    }
    class Class泛型1<T, G,Z> where T : class where G:new() where Z:T
    {
        //约束了t必须是class，G必须可以实例化
        //只能制定一个约束，  :错误	1	已经为类型参数“G”指定了 constraint 子句。必须在单个 where 子句中指定类型参数的所有约束。	E:\DEMO.NET\HomeSolution4.5\ConsoleITCast\.Net基础\Class泛型.cs	12	64	ConsoleITCast

    }
}
