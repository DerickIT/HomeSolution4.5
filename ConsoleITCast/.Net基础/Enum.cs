using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    /// <summary>
    /// 限制枚举中的类型只能是byte类型
    /// </summary>
    public enum states : byte
    {
        在线,
        离线,
        隐身
    }
}
