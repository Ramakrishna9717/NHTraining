using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_2
{
   /***********************************************************
    * Name:Ramakrishna
    * Purpose:Factorial 
    * *************************************************************/

    class mathametics
    {
        int fact = 1 ;
        int n;
        public void Readdata()
        {
            Console.WriteLine("Enter number");
             n = Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            for (int i=1; i<=n; i++)
                fact = fact*i;
                 return fact;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            mathametics m = new mathametics();
            m.Readdata();
            Console.WriteLine(m.Factorial());

            Console.ReadLine();
        }
    }
}
