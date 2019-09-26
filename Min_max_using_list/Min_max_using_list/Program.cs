using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Min_max_using_list
{
    class Program
    {
        
        private static float GetAverage(List<int> numberList)
        {

            float sum = 0;
            for (int i = 0; i < numberList.Count; i++)
            {

                 sum = sum + numberList[i];

            }
            float average = sum / numberList.Count;
            return average;
        }
        private static int GetMax(List<int> numberList)
        {
            int max = numberList[0];
           

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] > max)
                {
                    max = numberList[i];
                   
                }
            }
            return max;
        }
        private static int GetMin(List<int> numberList)
        {
            
            int min = numberList[0];

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] <min)
                {
                    min = numberList[i];

                }
            }
            return min;
        }
        public static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            Console.Write("Enter The Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < size; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
              
                numberList.Add(input);

                
            }
            Console.Write("The Average Is: ");
            float average = GetAverage(numberList);
            Console.WriteLine(average);
            int max = GetMax(numberList);
            Console.WriteLine("The Maximum Value Is: " + max);
            int min = GetMin(numberList);
            Console.WriteLine("The Minimum Value Is: " + min);
          
            Console.ReadKey();

        }

       

    }
}
