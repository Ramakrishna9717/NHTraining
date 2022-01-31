using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_1_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            int f = 1;
            fn = 20;
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=sn:i++)
                f =f *fn;
            Console.WriteLine("power ="+f);
            Console.ReadLine();
        }
    }
}
