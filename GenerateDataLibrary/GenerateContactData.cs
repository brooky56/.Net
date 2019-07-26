using MyFirstDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateDataLibrary
{
    public class GenerateContactData
    {
        public List<Contact> GenerateContacts()
        {
            Contact contact = new Contact
            {
                Name = "A",
                SurName = "AA",
                LastName = "AAA",
                Birthday = "01/01/1011",
                Inn = 12121212,
                Gender = EGender.Man.ToString(),
                PhoneNumber = "890087654",
                Position = "Doctor"
            };

            List<Contact> contacts = new List<Contact>();
            contacts.Add(contact);
            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                Contact addContact = new Contact
                {
                    Name = "A" + i,
                    SurName = "AA" + i,
                    LastName = "AAA" + i,
                    Birthday = "01/01/1011",
                    Inn = random.Next(),
                    Gender = EGender.Man.ToString(),
                    PhoneNumber = random.Next().ToString(),
                    Position = "Doctor" + i
                };
                contacts.Add(addContact);
            }

            return contacts;
        }
    }
}
