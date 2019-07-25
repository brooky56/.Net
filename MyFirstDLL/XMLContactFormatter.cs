using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    class XMLContactFormatter : IContactFormatter
    {
        public XMLContactFormatter() { }
        public void Format(Contact contact)
        {
            Console.WriteLine("We use only tags hahahah");
        }

    }
}
