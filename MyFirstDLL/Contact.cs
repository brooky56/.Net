using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace MyFirstDLL
{
    [TypeDescription(message:"Class")]
    
    public class Contact: Person, ICloneable
    {
        private string _Name;
        private string _SurName;
        private string _LastName;      
        private string _Birthday;
        private string _Inn;
        private string _Position;
        private string _PhoneNumber;
      

        public Contact(){}
        
        public string GetBirthdayAttributeValue()
        {
            string value = null;
            var customAttributes = (BirthdayAttribute[])typeof(Contact).GetCustomAttributes(typeof(BirthdayAttribute), true);
            if (customAttributes.Length > 0)
            {
                var myAttribute = customAttributes[0];
                value = myAttribute.Date;
            }
            return value;
        }

        [Conditional("DEBUG")]
        public void CheckClassAttributes() {
            TypeInfo typeInfo = typeof(Contact).GetTypeInfo();
            var attrs = typeInfo.GetCustomAttributes();
            foreach (var attr in attrs)
                Console.WriteLine("Attribute on Contact: " + attr.GetType().Name);
        }

    
       

        [Birthday("12/31/1900")]
        public string Birthday { get; set; }
        public int Inn { get; set; }
        public string Position { get; set; }

        public string PhoneNumber { get; set; }

        public object Clone()
        {
            return new Contact { Name = this.Name, SurName = this.SurName, LastName = this.LastName, Birthday = this.Birthday, Inn = this.Inn, Position = this.Position, PhoneNumber = this.PhoneNumber};
        }

        public override string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public override string SurName
        {
            get
            {
                return _SurName;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _SurName = value;
                }
            }
        }

        public override string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _LastName = value;
                }
            }
        }

        public override string DisplayPersonInfo()
        {
            throw new NotImplementedException();
        }
    }
}
