using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    static class StaticExtend
    {
        public static string reg(this string value)
        {
            return value.ToUpper();
        }
    }
}
