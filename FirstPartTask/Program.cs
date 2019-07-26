using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Globalization;
using System.Threading;
using MyFirstDLL;
using System.Collections;
using FormatterLibrary;

namespace FirstPartTask
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Creating new Contact.....");
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Contact contact = new Contact {
                Name = "A",
                SurName = "AA",
                LastName = "AAA",
                Birthday = "01/01/1011",
                Inn = 12121212,
                PhoneNumber = "89008765431",
                Position = "Doctor"
            };



            var factoryCSV = new ContactDataFormater().Run(Extensions.csv);
            Console.WriteLine(factoryCSV.Format(contact));


            var factoryXML = new ContactDataFormater().Run(Extensions.xml);
            Console.WriteLine(factoryXML.Format(contact));


            /**ContactFormatter formatter = new ContactFormatter();

            var farmottedData = formatter.Format(contact, format);

            ContacFileSaver contacFileSaver = new ContacFileSaver();

            contacFileSaver.SaveContact(contact,path);**/

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
