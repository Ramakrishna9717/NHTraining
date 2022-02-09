using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13_project_4
{
    /***********************************************************
     * author: Ramakrishna
     * purpose:Declare a 2-D array  and read values from user 
     * **********************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] data = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter array value");
                    data[i,j]=Convert.ToInt32(Console.ReadLine());   
                }
            }

                for (int i = 0; i<2; i++)
                {
                    for (int j = 0; j<2; j++)
                    {
                    Console.Write($"{data[i,j]} ");

                    }
                Console.Write("\n");
                }
                
                Console.ReadLine();

            }
        }
    }




