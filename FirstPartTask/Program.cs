using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Globalization;
using System.Threading;
using MyFirstDLL;

namespace FirstPartTask
{
    class Program
    {
        private static ContacFileSaver _ContacFileSaver;

        static void Main(string[] args)
        {

            Console.WriteLine("Creating new Contact.....");
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Contact newContact = new Contact {
                Name = "A",
                SurName = "AA",
                LastName = "AAA",
                Birthday = "01/01/1011",
                Inn = 12121212,
                Position = "Doctor"
            };
            Contact newContact1 = new Contact
            {
                Name = "B",
                SurName = "BB",
                LastName = "BBB",
                Birthday = "01/01/2011",
                Inn = 00908898,
                Position = "Nurse"
            };

            Type type = typeof(Contact);
            PropertyInfo propertyInfo = type.GetProperty(nameof(Contact.Birthday), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            BirthdayAttribute attr = propertyInfo.GetCustomAttributes<BirthdayAttribute>()?.FirstOrDefault();

            string limitDate = null;
            if (attr != null )
            {
                limitDate = attr.Date.ToString();
            }

            
            Console.WriteLine("Contact birthdate: " + newContact.Birthday);
            Console.WriteLine("Limit birthdate: " + limitDate);

       
            bool flag = CheckBirtdayLimit(limitDate, newContact);
            Console.WriteLine(flag.ToString());

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
        public static void SaveContact(Contact contact)
        {
            _ContacFileSaver = new ContacFileSaver();
            _ContacFileSaver.Save(contact);
            _ContacFileSaver.Dispose();

        }
    }
}
