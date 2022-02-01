using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_array
{
    class Product
    {
        public int id;
        public string name;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product() { id = 1, name = "apple",price=100},
                new Product() { id = 1, name = "Phone",price=5000},
                new Product() { id = 1, name = "watch",price=1000},
                new Product() { id = 1, name = "bat",price=3000},
            };

            //for loop
            for(int i=0;i<products.Length;i++)
            {
                Console.WriteLine($"id={products[i].id},name={products[i].name},price={products[i].price}");
            }

            //for eachloop
            foreach(var p in products)
            {
                Console.WriteLine($"id={p.id},name={p.name},price={p.price}");
            }

            //lamda expression
            products.ToList().ForEach(p => Console.WriteLine($"id={p.id},name={p.name},price={p.price}"));

            Console.ReadLine();
        }

    }
}
