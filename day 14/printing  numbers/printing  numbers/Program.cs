using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing__numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=30;i++)
            {
                if (i%3==0)

                    continue;
                Console.Write(i +"  ");

                Console.ReadLine();
            }
        }
    }
}
