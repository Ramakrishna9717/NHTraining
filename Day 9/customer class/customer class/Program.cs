using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_class
{
    class Employee
    {
        public int id;
        public String name;
        public int salary;
        public static string company = "nationsbenfits";


        public void ReadData()
        {
            Console.WriteLine("Enter Employee id:");
            id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name :");
            name =Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            salary =  Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine($"Id ={id},Name={name},Salary={salary},company={"nationsbenfits"}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadData();
            emp1.PrintData();


            Employee emp2 = new Employee();
            emp2.ReadData();
            emp2.PrintData();


            Console.ReadLine();
        }

        
        
    }
}
