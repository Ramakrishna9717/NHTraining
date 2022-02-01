using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_class
{
    internal class department
    {
        class departmemt
        {
            public int id;
            public string name;
            public string address;

            public void ReadDepartment()
            {
                Console.WriteLine("Enter id:");
                id=Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter name:");
                name=Console.ReadLine();

                Console.WriteLine("Enter address:");
                address=Console.ReadLine();

            }
            public void PrintDepartment()
            {
                Console.WriteLine($"Id={id},Name ={name},Address={address}");
            }
            static void Main(string[] args)
            {
                Departmemt  departmemt1 = new Department();

                departmemt1.ReadDepartment();
                departmemt1.PrintDepartment();


                Console.ReadLine();
            }
        }
    }
}
