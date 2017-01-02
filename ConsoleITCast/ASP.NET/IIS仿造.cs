using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
namespace ConsoleITCast.ASP.NET
{
    class IIS仿造
    {

        /*
      * 
      * 创建上下文对象
         * 创建httpapplication对象
         * 利用上下文对象读取到内容
         * 两个socket客户端通信
         * Buffer.blockCopy来拷贝传过来的文件
      */
        /// <summary>
        /// 只能处理静态网站
        /// </summary>
        public void meth()
        {
            // HttpContext s = new HttpContext();
            var sspath = AppDomain.CurrentDomain.BaseDirectory;
            
            //var fithname=Path.Combine(sspath,context.response.requesturl.trimstart('/')) 仿照iis读取文件夹内容，并且返回
            //context.response.bodydata=File.readallbytes(filename)
        }
    }
}
