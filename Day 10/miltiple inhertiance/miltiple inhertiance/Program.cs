using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miltiple_inhertiance
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
    class Totalmaths : Algebra
    {
        public int mul(int a, int b)
        {
            return a * b;
        }

        
    }
    class Allsubjects : Totalmaths
    {
        public string water()
        {
            return "h2O";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Allsubjects obj =  new Allsubjects();
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
