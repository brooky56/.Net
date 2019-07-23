using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstDLL
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TypeDescriptionAttribute:Attribute
    {
        private string _Description;

        public TypeDescriptionAttribute(string message)
        {
            this._Description = message;
        }

        public string TypeDisplay
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
    }
}
