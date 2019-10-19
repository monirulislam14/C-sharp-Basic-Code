using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Person person1 = new Person();

                person1.FirstName = Console.ReadLine();
                person1.LastName = Console.ReadLine();
                PersonAddress personAddress=new PersonAddress();
                personAddress.HouseNo = Console.ReadLine();
                personAddress.RoadNo = Console.ReadLine();
                personAddress.District = Console.ReadLine();
               
                string fullName = person1.GetFullName();
                Console.WriteLine(fullName);
                Console.WriteLine(personAddress.PersonDetails());
                
            } while (Console.ReadLine()=="y");
      

        }
    }
}
