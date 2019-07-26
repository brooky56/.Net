using MyFirstDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FormatterLibrary
{
    class XMLContactFormatter : IContactFormatter
    {
        public string Format(Contact contact)
        {
            string XMLFormattedString = GetXmlContactDocument(contact).ToString();
            return XMLFormattedString;
        }
        public XDocument GetXmlContactDocument(Contact contact)
        {
            XDocument xmlDocument = new XDocument(
             new XElement("contact",
                    new XAttribute("Name", contact.Name.ToString()),
                    new XAttribute("SurName", contact.SurName.ToString()),
                    new XAttribute("LastName", contact.LastName.ToString()),
                    new XAttribute("BirthDay", contact.Birthday.ToString()),
                    new XAttribute("Inn", contact.Inn.ToString()),
                    new XAttribute("Phone number", contact.PhoneNumber.ToString().Trim()),
                    new XAttribute("Postion", contact.Position.ToString())));

            return xmlDocument;
        }

    }
}
