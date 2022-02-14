using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramakrishna_libary
{
    internal class Mathamatics
    {
        int fact = 1;
        int n;
        public void Readdata()
        {
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            for (int i = 1; i<=n; i++)
                fact = fact*i;
            return fact;


        }
    }
} 
