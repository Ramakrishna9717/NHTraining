using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_to_print_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> data = new List<int>() { 56, 78, 99, 45, 95, 44, 56 };

            //using forloop
            for(int i=0;i<=data.Count;i++)
            {
                 if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            //foreachloop
            foreach(var d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);

            }
            //using lamda expression

            data.Where(d => d%2==0).ToList().ForEach(d => Console.WriteLine(d));

            //LINQ query

            var result=from d in data
                       where d%2==0
                       select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();


        }
    }
}
