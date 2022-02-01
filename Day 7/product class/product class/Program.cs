using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_class
{
    internal class Program
    {

        public int id;
        public string name;
        public int price;

        public void ReadProduct()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  product name");
            name=Console.ReadLine();

            Console.WriteLine("enter product price");
            price=Convert.ToInt32(Console.ReadLine());
        }
        public void PrintProduct()
        {
            Console.WriteLine($"Id={ id},name={ name},Price={price} ");
        }
        static void Main(string[] args)
        {
            Product  product1 = new Product();
            product1.ReadProduct();
            product1.PrintProduct();


            Console.Readline();
        }
    }
}
