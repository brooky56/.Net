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
                throw new ArgumentNullException();
            }
        }


        public void SaveContact(Contact contact, string path)
        {
            throw new NotImplementedException();
        }
    }
}
