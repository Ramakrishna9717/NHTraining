using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int number, remainder, sum = 0;
                Console.Write("enter the Number");
                number = Convert.ToInt32(Console.ReadLine());
                for (int i = number; i > 0; i = i / 10)
                {
                    remainder = i % 10;
                    sum = sum + remainder * remainder * remainder;

                }
                if (sum == number)
                {
                    Console.WriteLine("Entered Number is an Armstrong Number");
                }
                else
                    Console.WriteLine("Entered Number is not an Armstrong Number");
                Console.ReadLine();
            }
        }
    }

}
    

