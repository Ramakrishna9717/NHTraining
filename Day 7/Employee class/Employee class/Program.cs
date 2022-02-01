using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
             id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name=Console.ReadLine();

            Console.WriteLine("Enter salary:");
            salary=Convert.ToInt32(Console.ReadLine());

        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={id},Name={ name},Salary={ salary}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();
        }

    }
}
