using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inhertiance
{
    class Algebra
    {
        public int add(int a, int b)
        { 
            return a + b; 
        }   
        public int Sub(int a, int b)
         {
            return a - b; 
        }
    }
    class Totalmaths:Algebra
    {
        public int mul(int a, int b   )
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Totalmaths  tm = new Totalmaths();
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
