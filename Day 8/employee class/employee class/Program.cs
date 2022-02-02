using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_class
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
            List<Employee> employees = new List<Employee>()
            {
                new  Employee(){id=10,name="rk",salary=6000 },
                new  Employee(){id=20,name="Rama",salary=7000},
                new  Employee(){id=30,name="sai",salary=4000 },
                new Employee(){ id=40, name="krishna",salary=80000 },
                new  Employee(){id=50,name="sanjay",salary=3000 },
            };

            // usin forloop
            for(int i=0;i<employees.Count;i++)
            {
               if(employees[i].salary>5000)
                Console.WriteLine(employees[i].name);
            }
            //using foreachloop

            foreach (var e in employees)
            {
                if(e.salary>500)
                Console.WriteLine(e.name);
            }
            //lamda expression
            employees.Where(e =>e.salary>5000 ).ToList().ForEach(e=>Console.WriteLine(e.name));

            // LINQ  expression

            var result = from e in employees
                         where e.salary>5000
                         select e.name;
            result.ToList().ForEach(e => Console.WriteLine(e));


            Console.ReadLine();
          
  

        }
    }
}
