using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_input_by_alphabet
{
    class Program
    {


        static void Main(string[] args)
        {
            string eingabe = "";
            bool lowercase = true;
            string[] NameDatabase = new string[] {"Manfred Richter", "Thomas Neuburg", "Martin Müller", "Andreas Anders","Manfred Richter", "Tanja Ursel", "Janina Matheus", "Amy Davids", "Manfred Richter" };
            Console.WriteLine("Please write a name and this program will check if it exists in the database");
            eingabe = Console.ReadLine();
            
            for (int i=0; i<NameDatabase.Length; i++)
            {
                if (eingabe==NameDatabase[i])
                {
                    Console.WriteLine("Name '{0}' found at position {1}!", NameDatabase[i], i);
                    lowercase = false;
                }
            }

            if (lowercase==true)
            {
                eingabe = eingabe.ToLower();
                for (int i=0; i<NameDatabase.Length; i++)
                {
                    if (eingabe==NameDatabase[i].ToLower())
                    {
                        Console.WriteLine("Name '{0}' found after lowercase only check at position {1}!", NameDatabase[i], i);
                    }
                }
            }
            
        }
    }
}
