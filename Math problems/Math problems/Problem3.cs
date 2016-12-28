using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    public static class Problem3
    {
        /*
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */

        public static void Problem()
        {
            double number = 600851475143;
            double primefactor = 3;
            double biggestprimefactor = 0;
            while (primefactor != number)
            {
                if (number%primefactor == 0)
                {
                    
                    number= number / primefactor;
                }
                else
                {
                    primefactor++;
                }
                biggestprimefactor = primefactor;
            }
            Console.WriteLine("The biggest primefactor for the number 600851475143 is: {0}", biggestprimefactor);
        }
    }
}
