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
                    new XAttribute("Name", contact.Name.ToString())));

            return xmlDocument;
        }

    }
}
