using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_numbers
{
    class mathaddition
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
        public int addnumbers()
        {
            return a + b;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                mathaddition mt = new mathaddition();
                mt.ReadInput();
                Console.WriteLine(mt.addnumbers());
                Console.ReadLine();
            }
        }
    }
}
