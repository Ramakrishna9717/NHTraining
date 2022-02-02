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
        public string address;
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            customer[] customers = new customer[]
            {
                new customer() { id = 1, name = "rk",address="india"},

                new customer() { id = 2, name = "krishna",address="mumbai"},

                new customer () { id = 3, name = "sai",address="hyderbad"},

                new  customer() { id = 4, name = "satya",address="hitec city"},

            };
            //for loop 

            for (int i = 0; i<customers.Length; i++)
            {

                Console.WriteLine($"id={customers[i].id},name={customers[i].name},address={customers[i].address}");

            }



            //for eachloop 

            foreach (var c in customers)
            {

                Console.WriteLine($"id={c.id},name={c.name},address={c.address}");

            }
            //lamda expression 

            customers.ToList().ForEach(c => Console.WriteLine($"id={c.id},name={c.name},address={c.address}"));

            

            //linq expression
            var result = from  c in customers
                         select c;


            result.ToList().ForEach(c => Console.WriteLine($"id={c.id},name={c.name},address={c.address}"));



            Console.ReadLine();





        }
    }

}

