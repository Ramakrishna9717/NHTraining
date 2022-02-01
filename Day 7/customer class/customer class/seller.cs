using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_class
{
    
    internal class seller
    {
        public int id;
        public string name;
        public string address;

        public void ReadSeller()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter name:");
            name=Console.ReadLine();

            Console.WriteLine("Enter address:");
            address=Console.ReadLine();

        }
        public void PrintSeller()
        {
            Console.WriteLine($"Id={id},Name ={name},Address={address}");
        }
    }
    static void Main(string[] args)
    {
            seller seller1 = new seller();
            seller1.ReadSeller();
            seller1.PrintSeller();


            Console.ReadLine();
        }
    }
}



