using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            
            Console.WriteLine("smith");
            Console.WriteLine("smith@gmail.com");
            Console.WriteLine();
            

            //Q2
            
            Console.Write("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning {0}",name);

            Console.WriteLine();

            //Q3
            
            Console.Write("Enter the number for squaring :");
            int number = Convert.ToInt32(Console.ReadLine());
            int sqnumber = number * number;
            Console.WriteLine("square of {0}  is {1}", number, sqnumber);

            Console.WriteLine();
            //Q4
            
            Console.Write("Enter the number for squaring :");
           double numberQ4 =Convert.ToDouble(Console.ReadLine());
            double sqnumberQ4 = numberQ4 * numberQ4;
            Console.WriteLine("square of {0}  is {1}", numberQ4, sqnumberQ4);
            Console.WriteLine();

            //Q5

            Console.Write("Enter the number: ");
            double numberQ5;
            bool b = double.TryParse(Console.ReadLine(),out numberQ5);
            //number = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", numberQ5);
        }
    }
}
