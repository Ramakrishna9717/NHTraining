using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 20, 24, 12, 6, 4 };
            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
