using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_using_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n;
                {
                    Console.WriteLine("factorial of {0} = {1}", n, factorial(n));
                }
               int factorial(int n)
                {
                    if (n == 0)
                        return 1;
                    else
                        return n * factorial(n - 1);
                }
                static void Main(String[] args)
                {
                    int n = 5, n1 = 6, n2 = 7;
                    Printoutput(n);
                    Printoutput(n1);
                    Printoutput(n2);
                    Console.ReadLine();

                }




            }
        }

    }
}

