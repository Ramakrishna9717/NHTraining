using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.Read());
            for(i =1;i<=n;i++)
            { sum = sum+i;
                Console.WriteLine("sum ="+sum);

            }
            Console.ReadLine();
        }
    }
}
