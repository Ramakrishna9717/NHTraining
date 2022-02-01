using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

  

namespace product_array

{

    class customer

    {

        public int id;

        public string name;

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            customer[] customer = new customer[]


            {

                new customer() { id = 1, name = "rk",},

                new customer() { id = 1, name = "krishna",},

                new customer () { id = 1, name = "sai",},

                new  customer() { id = 1, name = "satya",},

            };



            //for loop 

            for (int i = 0; i<customer.Length; i++)

            {

                Console.WriteLine($"id={customer[i].id},name={customer[i].name}");

            }



            //for eachloop 

            foreach (var c in customer)

            {

                Console.WriteLine($"id={p.id},name={p.name}");

            }



            //lamda expression 

            customer.ToList().ForEach(p => Console.WriteLine($"id={c.id},name={c.name}"));



            Console.ReadLine();

        }



    }

}
