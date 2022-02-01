using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_variable
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }

     
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { id = 1, name = "Ramakrishna", salary=10000 };
            Console.WriteLine($"id={emp.id},name={emp.name},salary={emp.salary}");

            Console.ReadLine();
        }
    }
}
