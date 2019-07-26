using MyFirstDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatterLibrary
{
    public interface IContactFormatter
    {
        string Format(Contact contact);
    }
}
