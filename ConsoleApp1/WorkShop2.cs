using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WorkShop2
    {
        public static void Main()
        {
            //Q1 and Q2
            /*
            Console.Write("Enter the number for squareRoot: ");
            double sqnumber = Convert.ToDouble(Console.ReadLine());
            double answer = Math.Sqrt(sqnumber);
            Console.WriteLine("sqaureRoot of Given number: {0:0.000}", answer);
            */

            //Q3
            /*
            Console.Write("Enter the Salary Amount: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double salaryBenefit = salary + (salary * 0.10) + (salary * 0.03);
            Console.WriteLine("SalaryBenefit:{0:c}",salaryBenefit);
            */
            //Q4
            /*
            Console.Write("Enter the centigrade temperature: ");
            double temp = double.Parse(Console.ReadLine());
            double fehren = (1.8 * temp) + 32;
            Console.WriteLine("Given temperture into fehrenheit: {0}",fehren);
            */

            // Section C
            /*
            Console.Write("Enter the name:");
            string name = Console.ReadLine();
            Console.Write("Enter the Gender:");
            string gender = Console.ReadLine();
            string g;
            if (gender =="m")
            {
                g = "Mr.";
            }
            else
            {
                g= "Miss";
            }
            Console.WriteLine("Good Morning {0}{1}",g,name);
            */
        }
    }
}
