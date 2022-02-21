using Day_21__Project_1.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21__Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraSoapClient obj = new AlgebraSoapClient();
            
            Console.WriteLine(obj.Factorial(5));

            Console.WriteLine(obj.Add(7,6));

            Console.WriteLine(obj.mul(5,6));

            Console.ReadLine();
        }
    }
}
