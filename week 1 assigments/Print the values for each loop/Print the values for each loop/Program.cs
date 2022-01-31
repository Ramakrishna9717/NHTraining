using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_values_for_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ ] data = new int[] { 12, 5, 6, 4, 8 };
            foreach (int d in data)
                Console.WriteLine();
            Console.ReadLine();
        }
    }
}
