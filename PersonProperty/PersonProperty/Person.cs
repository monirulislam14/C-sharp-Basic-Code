using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProperty
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Designation { get; set; }
        public string Email { set; get; }
        public PersonAddress PersonAddressProperty { set; get; }
        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }
    }
}
