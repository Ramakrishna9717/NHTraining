using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product 
{
    class mathaproduct
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
        public int productnumbers()
        {
            return a*b;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                mathaproduct mt = new mathaproduct();
                mt.ReadInput();
                Console.WriteLine(mt.productnumbers());
                Console.ReadLine();
            }
        }
    }
}
