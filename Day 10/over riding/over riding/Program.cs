using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over_riding
{
    class englishmessage
    {
        public void printHI()
        {
            Console.WriteLine("Hi");
        }
        public void printHello()
        {
            Console.WriteLine("Hello");
        }
        public void printGoodevening()
        {
            Console.WriteLine("Goodevening");
        }
    }
    class Hindimessage : englishmessage
    {
            public new void printGoodevening()
            {
                Console.WriteLine("GV");
            }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hindimessage Hm = new Hindimessage();
            Console.WriteLine();

        }
    }
}
