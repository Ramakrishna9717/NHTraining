using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>  data = new List<string>();
            data.Add("rama");
            data.Add("krishna");
            data.Add("varun");
            data.Add("India");

            for(int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }
            foreach (var d in data)
            {
                Console.WriteLine(d);

            }  
               
            data.ForEach(p => Console.WriteLine(p));
                Console.ReadLine();
            
         }
    }
}
