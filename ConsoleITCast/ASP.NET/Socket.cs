using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace ConsoleITCast.ASP.NET
{
    class Sockets
    {
        /*
         * 创建ip
         * 创建socket
         * 绑定一个端口，绑定本地ip
         * 开始监听
         * Accept（）
         * 开启新的线程监听不同用户的访问端口
         * Receive（）
         * Listen（）
         * send（）
         * 
         *关闭： 服务器端出现异常表明客户端已经关闭，然后把socket关闭
         * 
         * 发送：socket  send()
         */
        public Socket serversocket { get; set; }

        public void sdf()
        {

            IPAddress ip = IPAddress.Parse("");
            IPEndPoint end = new IPEndPoint(ip, int.Parse(""));
            Socket cc = new Socket(AddressFamily.ImpLink, SocketType.Stream, ProtocolType.Tcp);
            cc.Bind(end);
            cc.Listen(20);
            ThreadPool.QueueUserWorkItem(a =>
            {
                Socket so = (Socket)a;
                while (true)
                {
                    var sooc = so.Accept();//创建socket对象
                    ThreadPool.QueueUserWorkItem(s =>
                    {
                        Socket soc = (Socket)s;//拿到代理socket
                        byte[] bytes = new byte[1024 * 1024];
                        int relength = sooc.Receive(bytes);//拿到数据大小
                        string strrequest = Encoding.UTF8.GetString(bytes, 0, relength);//读取数据内容
                        //处理当前的报文，解析当前报文
                    }, sooc);
                }
            }, cc
            );
        }
    }
}
