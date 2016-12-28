﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    public static class Problem2
    {
            /*
             * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
             * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
             * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
             */

        public static void Problem()
        {
            int value1 = 0;
            int value2 = 1;
            int newvalue = 0;
            int sum=0;
            while (newvalue<4000000)
            {
                newvalue = value1 + value2;
                value1 = value2;
                value2 = newvalue;
                
                //Check for even
                if (newvalue%2==0)
                {
                    //add the even term to the sum
                    sum += newvalue;
                }
            }
            Console.WriteLine("The Value of all even Fibonacci terms is: {0}", sum);
        }
    }
}
