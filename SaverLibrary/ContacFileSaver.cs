using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstDLL
{
    public sealed class ContacFileSaver: IDisposable, IContactSaver
    {
        private FileStream _FileStream;
          
        public ContacFileSaver(){}
      
        public void Dispose()
        {
            if (_FileStream != null)
            {
                _FileStream.Dispose();
            }
            else
            {
                Console.WriteLine("Some problems with file stream object");
                throw new ArgumentNullException();
            }
        }

        public void Info()
        {
            Console.WriteLine("Contact saved");
        }

        //vopros obrabotki bad transaction
        public void SaveContact(string contact, string path)
        {
            try
            {
                _FileStream = new FileStream(path, FileMode.Append | FileMode.OpenOrCreate);
                byte[] arr = ConvertStringToByteArray(contact);
                _FileStream.Write(arr, 0, arr.Length);
                Info();
            }
            catch {
                throw new Exception();
            }
        }

        private byte[] ConvertStringToByteArray(string contact)
        {
            return System.Text.Encoding.Default.GetBytes(String.Concat(contact,"\n"));
        }
    }
}
