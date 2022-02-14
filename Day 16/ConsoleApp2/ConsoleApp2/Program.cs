using System;
using System.Collections.Generic;
using System.Linq;
using Rk_libray;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathamatics m = new mathamatics();
            Console.WriteLine( m.Factorial(8));
            Console.WriteLine(m.add(33, 22));
            Console.WriteLine(m.mul(4, 4)); 

            Physics p = new Physics();
            Console.WriteLine(  p.Finalvelocity(4, 5, 6));

            Chemistry c = new Chemistry();
            Console.WriteLine( c.benzene());
            Console.WriteLine( c.water());
            Console.WriteLine( c.Methane());

            Console.ReadLine();


        }
    }
}
