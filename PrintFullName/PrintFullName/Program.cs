using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFullName
{
    class Program
    {    private static String GetFullName(String firstName,String middleName,String lastName)
        {
            String fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String middletName = Console.ReadLine();
            String lastName = Console.ReadLine();
            Console.WriteLine(GetFullName(firstName, middletName, lastName));
            Console.ReadKey();
        }
    }
}
