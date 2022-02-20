using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20__project_5
{
    internal class Program
    {
        private static void SetValue(ref string s)
        {
            // Checking parameter value
            if (s == "Hai")
            {
                Console.WriteLine("Welcome to my  C# world");
            }

            // assigning  value 
            s =  "Rk";

        }

        static void Main(string[] args)
        {
            string s1 = "Hai";
            SetValue(ref s1);
            Console.WriteLine(s1);
            Console.ReadLine();

        }
    }
}
