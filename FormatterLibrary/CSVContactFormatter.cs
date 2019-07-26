using MyFirstDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterLibrary
{
    public class CSVContactFormatter : IContactFormatter
    {
        public string Format(Contact contact)
        {
            string CSVFormattedString = GetCSVContactString(contact);
            return CSVFormattedString;
        }
        public string GetCSVContactString(Contact contact)
        {
            string coma = ";";
            return String.Concat(contact.Name,coma,
                contact.SurName, coma, 
                contact.LastName, coma, 
                contact.Birthday, coma,
                contact.Inn, coma,
                contact.PhoneNumber, coma,
                contact.Position, coma);
        }
    }
}
