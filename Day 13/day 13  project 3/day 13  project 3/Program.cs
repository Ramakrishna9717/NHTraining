using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13__project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int sum =0;
                int[,] data = new int[,] { { 5, 6,7 }, { 8, 4,3 }, { 11, 22,33 } };

                for (int i = 0; i<3; i++)
                {
                    for (int j = 0; j<3; j++)
                    {
                      if(i==j)
                        sum = sum + data[i,j];
                      
                    }
                
                }
            Console.WriteLine(sum);
            Console.ReadLine();

            }
        }
    }


 
