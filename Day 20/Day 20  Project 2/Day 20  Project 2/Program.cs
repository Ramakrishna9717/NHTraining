using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20__Project_2
{
    public delegate void mathematics(int a, int b);
    internal class Program
    {
        public static void Add(int  a ,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void Main(string[] args)
        {
            mathematics m = new mathematics(Add);
            m += sub;
            m += mul;
            m += Div;

            m(4, 5);

            m -=Add;
            m(10, 20);

            m-=sub;
            m-=mul;
            m(5, 10);

            Console.ReadLine();






        }
    }
}
