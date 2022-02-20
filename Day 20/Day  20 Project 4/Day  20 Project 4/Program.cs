using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__20_Project_4
{
    internal class Program
    {
        public static void Sum(out int i)
        {
            i = 90;
            i += 90;
        }

        static void Main(string[] args)
        {
            int i;
            Sum(out i);
            Console.WriteLine($"Sum of Value is : {i}");

            Console.ReadLine();

        }
    }
}
