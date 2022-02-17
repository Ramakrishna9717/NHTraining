using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Projecr_2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\XMLFILES\\Rk.Xml");
            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name=="name")
                    {
                        Console.WriteLine(cnode.InnerText);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
