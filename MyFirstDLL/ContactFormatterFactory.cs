using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public abstract class ContactFormatterFactory
    {
        public abstract IContactFormatter Create();
    }
}
