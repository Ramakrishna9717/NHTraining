using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declare__arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList  data =  new ArrayList();
            int sum = 0;
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(70);
            data.Add(90);
            foreach(var d in data)
            {
                sum= sum +(int)d;

            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
