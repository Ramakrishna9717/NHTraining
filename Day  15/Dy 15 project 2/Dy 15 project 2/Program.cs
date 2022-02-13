using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dy_15_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("C:\\1st folder\\Rk.text", " C:\\2 nd folder\\Rk.text");

            Console.WriteLine("File Transfered");

            Console.ReadLine();


        }
    }
}
