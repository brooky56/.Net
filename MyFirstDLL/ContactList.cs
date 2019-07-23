using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public class ContactList<T> :List<T>
    {
        private static List<T> _List;
        public ContactList()
        {
            _List = new List<T>();
        }

        public void AddContact(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _List.Add(value);
            }
        }
        public List<T> GetContactList()
        {
            return _List;
        }
        public T ContactSearch(T match)
        {
                if (match == null)
                {
                    throw new ArgumentNullException();
                }
 
                for (int i = 0; i < _List.Count; i++)
                {
                    if (match.Equals(_List[i]))
                    {
                        return _List[i];
                    }
                }
                return default(T);           
        }
    }
}
