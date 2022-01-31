using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabonacci__series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c, i;
            Console.WriteLine("Enter the number of terms : ");
            n =Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}

            
           
            
        
      

            
             
    }
}
