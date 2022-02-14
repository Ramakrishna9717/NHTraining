using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    /**************************************************
     * name:Ramakrishna
     * purpose:Palindrome or not
     * ****************************************************/
    class maths
    {
        int n, r;
        int sum = 0;
           int temp;

        public void Readdata()
        {
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        public void Palindrome()
        {
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrome.");
            else
                Console.WriteLine("Number is not Palindrome");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                maths m = new maths();
                m.Readdata();
                m.Palindrome();
                Console.ReadLine();
            }
        }
    }
}
