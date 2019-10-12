using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string firstName;
            string midleName;
            string lastName;
            Person person1 = new Person("monirul","islam");
            Person person2 = new Person();
            //person1 is reference and Person() is object
           
            person1.firstName = "monirul";
            person1.midleName = "islam";
            person1.lastName = "mondal";
            person2 = person1;
          
           
           
            Console.WriteLine(person1.GetFullName());
            change(person2);
            Console.WriteLine(person2.GetFullName());
            Console.WriteLine(person2.GetReversedName());
            Console.ReadKey();
        }
        public static void change(Person person)
        {
            person.lastName = "Changed";
        }
    }
}
