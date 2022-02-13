using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:\\rama\\netproject\\Day  15\\File copy\\Hello.text", true);
            sw.WriteLine("Welcome");
            sw.WriteLine("to");
            sw.WriteLine("NH Training");
            sw.Close();

            Console.WriteLine(" File Created");

            Console.ReadLine(); 

        }
    }
}
