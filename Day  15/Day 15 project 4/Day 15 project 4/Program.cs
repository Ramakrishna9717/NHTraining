using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = new StreamReader("D:\\rama\\netproject\\Day  15\\File copy\\Hello.text");

            String data = str.ReadLine();

            while (data!= null)
            {
                Console.WriteLine(data);
                data = str.ReadLine();
            }

            Console.WriteLine("\n\n File Reading done");

            Console.ReadLine();

        }
    }
}
