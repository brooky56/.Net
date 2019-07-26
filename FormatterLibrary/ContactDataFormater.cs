using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterLibrary
{
    //here you can extend the list of formats for future
    public enum Extensions 
    {
        csv,
        xml
    }

    public class ContactDataFormater 
    {
        private readonly Dictionary<Extensions, ContactFormatterFactory> _factories;
        public ContactDataFormater()
        {
                _factories = new Dictionary<Extensions, ContactFormatterFactory>
                {
                    { Extensions.csv, new CSVFormatterFactory()},
                    { Extensions.xml, new XMLFormatterFactory()}
                };
        }

        public IContactFormatter Run(Extensions extensions) => _factories[extensions].Create();
    }
}
