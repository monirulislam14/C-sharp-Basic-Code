using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dictionary_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> dt = new Dictionary<int, String>();

            int size;
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                dt.Add(i, Console.ReadLine());
            }
            //ICollection key = ht.Keys;




            // Get a collection of the keys.


            foreach (var k in dt.Keys)
            {
                Console.WriteLine(k + ": " + dt[k]);
            }
            Console.ReadKey();
        }
    }
}
