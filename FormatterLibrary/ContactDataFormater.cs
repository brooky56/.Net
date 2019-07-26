using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterLibrary
{
   
    public class ContactDataFormater 
    {
        private readonly Dictionary<EExtensions, ContactFormatterFactory> _factories;
        public ContactDataFormater()
        {
                _factories = new Dictionary<EExtensions, ContactFormatterFactory>
                {
                    { EExtensions.csv, new CSVFormatterFactory()},
                    { EExtensions.xml, new XMLFormatterFactory()}
                };
        }
        /// <summary>
        /// Function depend on choosen exstention invoke method Create() from ContactFormatterFactory class
        /// </summary>
        /// <param name="extensions"></param>
        /// <returns></returns>
        public IContactFormatter Run(EExtensions extensions) => _factories[extensions].Create();
    }
}
