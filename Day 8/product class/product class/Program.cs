using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace products

{
    class products

    {

        public int id;
        public string name;
        public int price;
        public string brand;

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            List<products>  products = new  List<products>()
            {

                new products() { id = 1, name ="mobile", price =600, brand ="Nokia" },
                new products() { id = 2, name ="watch", price =200, brand ="iwatch" },
                new products() { id = 3, name ="bat", price =300, brand ="mrf" },
                new products() { id = 4, name ="laptop", price =600, brand ="iphone" },

            };
            // using forloop 

            for (int i = 0; i<products.Count; i++)

            {

                if (products[i].price>500)
                    Console.WriteLine($"name={products[i].name},brand={products[i].brand}");

            }
            // foreach loop
            foreach(var p in products)
            {
                if(p.price>500)
                    Console.WriteLine($"name={p.name},brand={p.brand}" );

            }
            //using lamda function
            products.Where(p => p.price>500).ToList().ForEach(p =>Console.WriteLine($"name={p.name},brand={p.brand}"));


            //using linq function
            var result = from p in products
                         where p.price>500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));

            Console.ReadLine();
                






            Console.ReadLine();







        }

    }

}
