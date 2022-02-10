using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normal_properties
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;

        public int Id
        {
            get { return id; }
            set { id = 5555; }
        }
        public string Name
        {
            get { return name; }
            set { name = "Rk"; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = 10000; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Employee emp = new Employee();
                emp.Id = 5555;
                emp.Name = " Rk";
                emp.Salary = 10000;

                Console.WriteLine(emp.Id);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);

                Console.ReadLine();
            
        }
    }
}
  

