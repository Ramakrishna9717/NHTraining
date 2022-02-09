using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(24);
            data.Enqueue(35);
            data.Enqueue(45);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);

            Console.ReadLine();

        }
    }
}
