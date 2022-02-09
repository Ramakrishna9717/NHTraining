
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0]= new char[] { 'R', 'K' };
            names[1] = new char[] { 'k', 'r', 'i', 's', 'h', 'n', 'a' };
            names[2] = new char[] { 'S', 'a', 'n', 'j', 'a', 'y' };


            for(int i=0;i<3;i++)
            {
                for(int j=0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
