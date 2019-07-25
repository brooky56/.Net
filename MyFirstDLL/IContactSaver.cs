using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public interface IContactSaver
    {
        void SaveContact(Contact contact, string path);
    }
}
