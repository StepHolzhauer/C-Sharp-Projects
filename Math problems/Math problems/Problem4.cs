using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    public static class Problem4
    {
        /*
         * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */

        public static void Problem()
        {
            int sum1 = 0;
            int sum2 = 0;

            //exp of natural numbers added together
            for(int i=1;i<=100;i++)
            {
                sum1 += i * i;
            }
            //natural numbers added together and exp
            for(int i=1;i<=100;i++)
            {
                sum2 += i;
            }
            sum2 = sum2 * sum2;

            //Write difference between sum1 and sum2
            Console.WriteLine("sum2 {0}", sum2);
            Console.WriteLine("sum1 {0}", sum1);
            Console.WriteLine("The Difference between natural numbers^2 and the square of their sum is: {0}", (sum2-sum1));
        }
    }
}
