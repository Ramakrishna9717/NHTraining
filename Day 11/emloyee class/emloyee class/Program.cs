using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emloyee_class
{
    class employee
    {
        private int id;
        private string name;
        private string desigination;
        private int salary;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Desigination
        {
            get { return desigination; }
            set { desigination = value; }
        }
        public int Salary
        {
            get 
            {
                salary=(desigination=="s") ? 3000 : 6000;
                return salary;
            }
        }
    }    

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp =new employee();
            emp.Desigination="m";
            Console.WriteLine(emp.Salary);

           emp.Desigination="s";
            Console.WriteLine(emp.Salary);


            Console.ReadLine();
        }
    }
}
