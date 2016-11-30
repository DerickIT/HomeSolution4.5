using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Filestream
    {
        /// <summary>
        /// 读取文件展现出来
        /// </summary>
        public void test()
        {
            /*
             创建缓冲区存储读取的内容
             */
            FileStream fs = new FileStream("", FileMode.Open);
            byte[] bytes = new byte[fs.Length];//缓冲区
            int r = fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            fs.Dispose();
            string fas = UTF8Encoding.UTF8.GetString(bytes);
        }
    }
}
