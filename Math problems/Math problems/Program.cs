using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    class Program
    {
        static int inputcheck(string input)
        {
            int selection;
            try 
            {
                selection = Convert.ToInt32(input);
                return selection;
            }
            catch
            {
                Console.WriteLine("ONLY NUMBERS OF EXISTING PROBLEMS");
                Console.WriteLine("Closing...");
                Environment.Exit(0);
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int selection;
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Please select a math problem:");
                Console.WriteLine("1. Multiples of 3 and 5 to 1000");
                Console.WriteLine("2. Fiboncci below 4 million");
                Console.WriteLine("3. largest prime factor of the number 600851475143?");
                Console.WriteLine("4. difference between the sum of the squares of the first one hundred natural numbers and the square of the sum");
                Console.WriteLine("5. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");
                selection = inputcheck(Console.ReadLine());
                Console.WriteLine("{0} selected", selection);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");

                switch (selection)
                {
                    case 1:
                        Problem1.Problem();
                        break;
                    case 2:
                        Problem2.Problem();
                        break;
                    case 3:
                        Problem3.Problem();
                        break;
                    case 4:
                        Problem4.Problem();
                        break;
                    case 5:
                        Problem5.Problem();
                        break;

                    default:
                        Console.WriteLine("Nothing found.");
                        break;
                }
                
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}
