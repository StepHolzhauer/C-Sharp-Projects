using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * FIZZBUZZ with shown numbers besides FIZZ and BUZZ numbers
 */

namespace FizzBuzz
{
    public static class Global
        {
            public static bool fizbuz = false;
        }

    class Program
    {
        

        static void Fizz(int input)
        {
            if (input % 3 == 0)
            {
                Console.Write("Fizz");
                Global.fizbuz=true;
            }
        }

        static void Buzz(int input)
        {
            if (input % 5 == 0)
            {
                Console.Write("Buzz");
                Global.fizbuz=true;
            }
        }

        static void Main(string[] args)
        {
            int eingabe = 0;
            while (eingabe <= 100)
            {
                Fizz(eingabe);
                Buzz(eingabe);
            
            if (Global.fizbuz == false)
               Console.Write(eingabe);
            Global.fizbuz = false;
            eingabe++;
            Console.WriteLine("");
            }

        }
    }
}
