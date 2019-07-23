using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public class ContactStack<T>
    {
        private static List<T> _List = new List<T>();

        public int Size
        {
            get
            {
                return _List.Count;
            }
        }
        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            _List.Add(value);
        }
        private T GetTopItem()
        {
            var value = _List.LastOrDefault();

            if (value == null)
            {
                throw new ArgumentNullException();
            }
            return value;
        }
        public T Pop()
        {
            var value = GetTopItem();
            _List.Remove(value);
            return value;
        }
        public T Peek()
        {
            return GetTopItem();
        }
    }
}
