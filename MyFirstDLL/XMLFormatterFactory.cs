using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    class XMLFormatterFactory: ContactFormatterFactory
    {
        public override IContactFormatter Create() => new XMLContactFormatter();
    
    }
}
