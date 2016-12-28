using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    public static class Problem1
    {
        /*
         *Problem: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         *Find the sum of all the multiples of 3 or 5 below 1000.
         */

        public static void Problem()
        {
            int sum = 0;
            Console.WriteLine("Problem 1 Selected: Find the sum of all the multiples of 3 or 5 below 1000");
            Console.WriteLine("");
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3) == 0)
                {
                    sum += i;
                }
                else if ((i % 5) == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The Sum of all multiples of 3 or 5 below 1000 is: {0}", sum);
        }
    }
}
