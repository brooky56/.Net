using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDLL
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract string SurName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string DisplayPersonInfo();

    }
}
