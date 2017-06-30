using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Generator!");
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Enter an integer that is greater than 0 but less than 10: ");
                int i = int.Parse(Console.ReadLine());
                int result = i;

                for (int j = 1; j < i; j++)
                {
                    result = result * j;
                }

                Console.WriteLine($"The factorial of {i} is {result}.");
                run = Continue();
            }
        }
            public static Boolean Continue() {
            {
                Boolean run;
                Console.WriteLine("Continue? y/n ");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    run = true;
                }
                else if (answer == "n" || answer == "N")
                {
                    run = false;
                    Console.WriteLine("Thank you for using this program. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Input not valid. Please try again.");
                    run = Continue();
                }
                return run;
            }
            }
    }
}
