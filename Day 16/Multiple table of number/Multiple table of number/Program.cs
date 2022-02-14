using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_table_of_number
{
    class Mathematics
    {
        int n;
        public void Readdata()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
       
        public void Printdata()
        {
            for (int i = 1; i <= 10; i++)
            {
             Console.WriteLine($"{n}*{i}={i * n}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.Readdata();
            m.Printdata();
            Console.ReadLine();
        }
    }
}
