using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstDLL
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BirthdayAttribute : Attribute
    {
        private string _Date;

        public BirthdayAttribute(string date)
        {
            this._Date = date;
        }

        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
       
    }
}
