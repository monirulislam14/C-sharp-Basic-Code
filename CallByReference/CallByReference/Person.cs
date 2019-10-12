using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    class Person
    {
        public string firstName;
        public string midleName;
        public string lastName;
        public string id;

        public Person()
        {
                 id = "0000";
          
        }
        public Person(string firstName,string lastName):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName, string midleName,string lastName):this(firstName,lastName)
        {
            this.midleName = midleName;
        }
        public string GetFullName()
        {
            string fullname;
            if (midleName == null)
            {
               fullname =firstName +" " + lastName;
            }
            else if (midleName != null)
            {
                fullname = " " + firstName + " " + midleName + " " + lastName;
            }
            fullname = " " + firstName + " " + midleName + " " + lastName;
            return fullname;
        }
        public string GetReversedName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
