﻿using ConsoleITCast.Net基础;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast
{
    class Program
    {
        static void Main(string[] args)
        {
            computer com = new computer();
            com.Disk = new mp3();
            com.read();
            var m3 = new mp3();
            m3.player();
            object.ReferenceEquals(m3, m3);
            int num = 0;
            var sub = 0;
           var bo= num.Equals(sub);

        }
        public int add(params int[] arr)
        {
            int num = 0;
            var sub = 0;
            num.Equals(sub);
            for (int i = 0; i < arr.Length; i++)
            {//如果有其他参数，可变参数必须放到最后一个
                num += arr[i];
            }
            return num;
        }
    }


}
