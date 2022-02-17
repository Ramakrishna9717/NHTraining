using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID Number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            XmlDocument file = new XmlDocument();
            file.Load("C:\\XMLFILES\\products.Xml.Xml");


            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    bool id = cnode.Name == "id";
                    bool isIndex = (id == true ? Convert.ToInt32(cnode.InnerText) : 0) == input;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"The name of  ID is {cnode.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
