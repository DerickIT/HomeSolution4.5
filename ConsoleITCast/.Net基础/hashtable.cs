using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class hashtable
    {
        public void Hashtables()
        {
            Hashtable hb = new Hashtable();
            hb.Add(1, 2);//以键值对形式添加
        }
    }
    class arraylist
    {
        //ArrayList arrlist = new ArrayList();
        ArrayList a = new ArrayList();
        public void sd()
        {
            a.Add(1);
            while (a.Contains("a"))
            {
                var dic = new Dictionary<string, int>();
                dic.Add("zhn", 7);//使用字典dictionary
                foreach (KeyValuePair<string, int> item in dic)
                {
                    var s = item.Key + item.Value;
                }
            }
        }

        public int Maxi(int[] arrint)
        {
            var aaa = new int[] { 1, 4, 2, 3, 5, 6 };
            int a = arrint[0];
            for (int i = 0; i < arrint.Length; i++)
            {
                if (a < arrint[i])
                {
                    a = arrint[i];
                }
            }
            return 0;
        }
    }
}
