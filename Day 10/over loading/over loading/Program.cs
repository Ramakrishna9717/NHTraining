using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over_loading
{
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;

        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b, int c, int d)
        {
            return a +b + c + d;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra obj = new Algebra();
            Console.WriteLine();
        }
    }
}
