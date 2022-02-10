using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_implemented_properties
{
      class Employee
      {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


      }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 9999;
            emp.Name =" RAMA KRISHNA ";
            emp.Salary = 250000;

            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);

            Console.ReadLine();
        }
    }
}

