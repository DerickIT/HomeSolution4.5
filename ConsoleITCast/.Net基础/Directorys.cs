using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Directorys
    {
        [Obsolete("表示这个是过时方法，后期将不在维护")]
        public void method()
        {
            Directory.Delete("");//删除操作
            Directory.CreateDirectory("");//创建文件夹
            Directory.GetDirectories("");//返回路径中所有的文件路径
        }
    }
}
