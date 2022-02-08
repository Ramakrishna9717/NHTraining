using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematics_class
{
    class mathematics
    {
        public static int ADD(int a,int b)
        {
            return a + b;
        }
        public static int sub(int a,int b)
        {
            return a-b;
        }
        public static int mul(int a,int b)
        { 
            return a*b;
        }
    }
    internal class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine(mathematics.ADD(20,30));
            Console.WriteLine(mathematics.sub(55, 28));
            Console.WriteLine(mathematics.mul(5, 8));

            Console.ReadLine();
        }
    }
}
