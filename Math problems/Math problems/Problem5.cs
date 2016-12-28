using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_problems
{
    /*
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */
    public static class Problem5
    {
        public static void Problem()
        {
            int counter = 20;
            bool closingcheck = false;
            bool correctcheck = true;
            int i=1;
            while (closingcheck == false)
            {
                while (i <= 20)
                    {
                        if (counter % i != 0)
                        {
                            counter+=20;
                            correctcheck = false;
                            i = 1;
                        }

                        if ((i == 20) && (counter % i == 0) && (correctcheck == true))
                        {
                            closingcheck = true;
                        }
                        i++;
                    }
                
                i = 1;
                correctcheck=true;
            }
            Console.WriteLine("{0}", counter);
        }
    }
}
