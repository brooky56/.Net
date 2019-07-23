using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstDLL
{
    public class ContacFileSaver:IDisposable
    {
        private FileStream _FileStream;
        public ContacFileSaver()
        {
            _FileStream = new FileStream("test.csv", FileMode.OpenOrCreate);
        }
        public void Save(Contact contact)
        {
            string info = ContactStringCreating(contact);
            byte[] arr = Encoding.ASCII.GetBytes(info);
            _FileStream.Write(arr,0, arr.Length);
        }
        public void Dispose()
        {
            _FileStream.Close();    
        }
        private string ContactStringCreating(Contact contact)
        {
            return contact.Name + ";" + contact.SurName + ";" + contact.LastName + ";" + contact.Birthday + ";" + contact.Inn.ToString() +  ";"+ contact.Position+"\n";
        }
    }
}
