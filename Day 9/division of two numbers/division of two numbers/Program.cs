using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division 
{
    class mathadivision
    {
        private int a;
        private int b;

        public void ReadInput()
        {
            Console.WriteLine("Enter a number");
            a =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b number");
            b =Convert.ToInt32(Console.ReadLine());

        }
        public int divisionnumbers()
        {
            return a/b;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                mathadivision mt = new mathadivision();
                mt.ReadInput();
                Console.WriteLine(mt.divisionnumbers());
                Console.ReadLine();
            }
        }
    }
}
