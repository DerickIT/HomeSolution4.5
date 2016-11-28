using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    public class index__ : IEnumerable
    {
        public List<string> car = new List<string>();
        private string[] name = new string[] { "zhn", "2", "3", "4", "5" };
        public string this[int index]
        { get { return name[index]; } set { name[index] = value; } }
        public void method(states s)
        {
            s = states.离线;
        }


        public IEnumerator GetEnumerator()
        {
            return new indexIEnumerator(car);
        }
    }

    public class indexIEnumerator : IEnumerator<index__>
    {
        public List<string> _car;
        public indexIEnumerator(List<string> car)
        {
            _car = car;
        }

        public int Index = -1;
        //表示当前正在遍历的对象
        public object Current
        {
            get { return _car[Index]; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            Index += 1;
            if (Index < _car.Count)
            {
                return true;

            }
            else
                return false;
        }

        public void Reset()
        {
            Index = -1;//让index索引复位
        }
    }
}
