using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Streamreadandwrite
    {
        public void test()
        {
            using (StreamReader sr = new StreamReader(""))
            {
                if (!sr.EndOfStream)
                {
                    //读取到最后一行
                }
                string mowei = sr.ReadLine();
                while (mowei!=null)
                {
                    
                }
                using (StreamWriter sw=new StreamWriter ("lujing"))
                {
                    //string.Join("|", 0);数组分割后可以使用这个重新组合到一起
                }//序列化是将对象变成流‘byte’的方法
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("",FileMode.Open);
            bf.Serialize(fs, "实体类对象等");//根据对象来序列化
            bf.Deserialize(fs);//反序列化是通过原来的程序ji来创建的，也就是说原来的文件中只是包含一些数据，根据这些数据是无法在内寸中创建对象的，只能根据原来对象数据集来创建对象
        }
    }
}
