using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__20_Project__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte? input = null;

            if (input.HasValue)
            {
                Console.WriteLine(input * input);
            }
            else
            {
                Console.WriteLine("No Value");
            }
            Console.ReadLine();
        }
    }
}

