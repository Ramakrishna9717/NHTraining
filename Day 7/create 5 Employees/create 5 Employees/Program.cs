using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_5_Employees
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
            Employee[] employees = new Employee[]
            {
                new Employee(){ id = 1, name = "Ramakrishna",salary=8000},
                new Employee(){ id = 2, name = "Chintu",salary=4000},
                new Employee(){ id = 1, name = "sanjay",salary=6000},
                new Employee(){ id = 1, name = "sai",salary=3000},
                new Employee(){ id = 1, name = "teja",salary=7000},

            };

            // for loop
            for(int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"id={employees[i].id},name={employees[i].name},salary ={employees[i].salary}");
            }

            //for each loop
            foreach(var e in employees)
            {
                Console.WriteLine($"id={e .id},name={e.name},salary={e.salary}");
            }

            // lamda expression
            employees.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            Console.ReadLine();
        }
    }
}
