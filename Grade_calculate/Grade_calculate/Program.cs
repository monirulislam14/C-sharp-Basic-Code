using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Grade_calculate
{
    class Program
    {    private static String GetResultInGrade(int marks)
        {

            if (marks >= 40 && marks <= 45)
                return "D";
            else if (marks >= 45 && marks <= 49)
                return "C";
            else if (marks >= 50 && marks <= 54)
                return "C+";
            else if (marks >= 55 && marks <= 59)
               return "B-";
           else if (marks >= 60 && marks <= 64)
                return "B";
            else if (marks >= 65 && marks <= 69)
                return "B+";
            else if (marks >= 70 && marks <= 74)
                return "A-";
            else if (marks >= 75 && marks <= 79)
                return "A";
            else if (marks >= 80 && marks <= 100)
                return "A+";
           else
            return "Faild";
        }
        static void Main(string[] args)
        {
            int marks = Convert.ToInt32(Console.ReadLine());
           String result =GetResultInGrade( marks);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
