using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multplication_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("Enter ant number");
            input=Convert.ToInt32(Console.ReadLine());
            for(i =1;i<=10;i++)
                {
                Console.WriteLine(input+"x"+i+"="+input*i);
            }
            for(i =1;i<=10; i++)
            {
                Console.WriteLine(input +"x" +i +"="+ input *i);
            }
            Console.ReadLine();
        }
    }
}
