using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ramakrishna_library;
using public_library;

namespace Client_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Factorial(5));
            Console.WriteLine(Mathematics.Add(5, 6));
            Console.WriteLine(Mathematics.mul(5,4));
            Console.WriteLine(Mathematics.Divide(20,5));

            Console.WriteLine(Physics.FinalVelocity (5,6,7));

            Console.ReadLine();
        }
    }
}
