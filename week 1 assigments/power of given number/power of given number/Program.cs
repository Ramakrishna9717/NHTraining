using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_of_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, result = 1, i;
            Console.WriteLine("Enter value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b");
            b = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= b; i++)
                result = result * a;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
