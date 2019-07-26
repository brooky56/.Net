using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Globalization;
using System.Threading;
using MyFirstDLL;
using System.Collections;
using FormatterLibrary;
using System.IO;
using GenerateDataLibrary;

namespace FirstPartTask
{
    class Program
    {
        private static readonly string _FileName = "test";
        private static readonly string _Path = Path.Combine(Environment.CurrentDirectory,_FileName);
        private static readonly string dot = ".";

        static void Main(string[] args)
        {

            Console.WriteLine("Creating new Contact.....");
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            GenerateContactData generater = new GenerateContactData();

            List<Contact> contacts = generater.GenerateContacts();
                     
            
            foreach (Contact con in contacts)
            {
                var formatterCSV = new ContactDataFormater().Run(EExtensions.csv);
                string contactStringCSV = formatterCSV.Format(con);
                ContacFileSaver contacFileSaverForCSV = new ContacFileSaver();
                contacFileSaverForCSV.SaveContact(contactStringCSV, String.Concat(_Path, dot, EExtensions.csv.ToString()));
                contacFileSaverForCSV.Dispose();
            }


            foreach (Contact con in contacts)
            {
                var formatterXML = new ContactDataFormater().Run(EExtensions.xml);
                string contactStringXML = formatterXML.Format(con);
                ContacFileSaver contacFileSaverForXML = new ContacFileSaver();
                contacFileSaverForXML.SaveContact(contactStringXML, String.Concat(_Path, dot, EExtensions.xml.ToString()));
                contacFileSaverForXML.Dispose();
            }

            Console.ReadKey();
        }

        public static bool CheckBirtdayLimit(string limitDate, Contact contact)
        {
            bool isValited = false;
             
            DateTime contactDate = Convert.ToDateTime(contact.Birthday);
            DateTime limitDateTime = Convert.ToDateTime(limitDate);
            int result = DateTime.Compare(contactDate,limitDateTime);
            if (result >= 0)
            {
                isValited = true;
                return isValited;
            }
            
            return isValited;
        }

        public static void ContactBirthdayInfo(Contact contact)
        {
            Type type = typeof(Contact);
            PropertyInfo propertyInfo = type.GetProperty(nameof(Contact.Birthday), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            BirthdayAttribute attr = propertyInfo.GetCustomAttributes<BirthdayAttribute>()?.FirstOrDefault();

            string limitDate = null;
            if (attr != null)
            {
                limitDate = attr.Date.ToString();
            }


            Console.WriteLine("Contact birthdate: " + contact.Birthday);
            Console.WriteLine("Limit birthdate: " + limitDate);

            bool flag = CheckBirtdayLimit(limitDate, contact);
            Console.WriteLine(flag.ToString());
        }

        
        
    }
}
