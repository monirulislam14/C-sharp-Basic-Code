using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameAndGrade
{     
    class Program
    {
        private static String GetResultInGrade(int marks)
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
                return "Failed";
        }
        private static String GetGradeAndName(string firstName, string lastName, string subject,int marks)
        {
            String fullName = firstName + " " + lastName;
           String grade= GetResultInGrade(marks);
            if (grade == "Failed")
            {
                return "Sorry! you have failed. Please try again! ";
            }
            else 
            {
                return "Hello " + fullName + " Congratulation! You have passed in " + subject + " and your grade is " + grade;
            }
        }
        static void Main(string[] args)
        {
            do {
                Console.WriteLine("Enter Your First Name:");
                String firstName = Console.ReadLine();
                Console.WriteLine("Enter Your Last Name:");
                String lastName = Console.ReadLine();
                Console.WriteLine("Enter Your Subject:");
                String subject = Console.ReadLine();
                Console.WriteLine("Enter Your Marks:");
                int marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetGradeAndName(firstName, lastName, subject, marks));
                Console.WriteLine("\nDo you want to continue.?  \n(y / n) ");
                Console.ReadKey();
            }
            while (Console.ReadKey().KeyChar == 'y');
            

        }
    }
}

        
    
