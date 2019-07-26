using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterLibrary
{
    public class CSVFormatterFactory : ContactFormatterFactory
    {
        public override IContactFormatter Create() => new CSVContactFormatter();
    }
}
