using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("Enter any number:");
            input=Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=input; input++)
            { if (input%input==0)
                    Console.WriteLine(i);

            }
            Console.ReadLine();
        } 
    }
