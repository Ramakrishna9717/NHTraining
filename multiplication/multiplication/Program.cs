using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[10];
            for (int i = 0; i<data.Length; i++)
            { Console.WriteLine("enter number");
                data[i] =Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i<data.Length; i++)
            {
                sum = sum + data[i];
                Console.WriteLine("sum="+sum);
            }
             
        }
    }
}
