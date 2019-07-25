using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public class CSVContactFormatter : IContactFormatter
    {
        public CSVContactFormatter() { }


        public void Format(Contact contact)
        {
            Console.WriteLine("We use only ;");
        }
    }
}
