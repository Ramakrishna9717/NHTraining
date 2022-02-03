using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_numbers
{
    class mathasubraction
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
        public int subractionnumbers()
        {
            return a - b;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                mathasubraction mt = new mathasubraction();
                mt.ReadInput();
                Console.WriteLine(mt.subractionnumbers());
                Console.ReadLine();
            }
        }
    }
}
