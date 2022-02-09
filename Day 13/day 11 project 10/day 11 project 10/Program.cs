using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11_project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();

            data.Push(20);
            data.Push(4);
            data.Push(55);
            data.Push(12);


            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);


            Console.ReadLine();
        }
    }
}
