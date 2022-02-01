using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_class
{
    class Customer
    {
        public int id;
        public string name;
        public string address;
        
        public void  ReadCustomer()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter name:");
            name=Console.ReadLine();

            Console.WriteLine("Enter address:");
            address=Console.ReadLine();

        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Id={id},Name ={name},Address={address}");
          }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ReadCustomer();
            customer1.PrintCustomer();


            Console.ReadLine();
        }
    }
}
