using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_with_out_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 20, b = 30;


                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine("Values after swapping are:");
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
                Console.ReadLine();
            }
        }
    }
}

       
    

