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


        public  Employee()
        {
            this.id=0;
            this.name=null;
            this.salary=0;
        }
         public  Employee(int eid,string ename,int esalary)
         {
            id = eid;
            name = ename;
            salary = esalary;
         }


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
            Employee emp = new Employee(2,"ramakrishna",8000);
            emp.PrintData();

            Console.ReadLine();
        }



    }
}