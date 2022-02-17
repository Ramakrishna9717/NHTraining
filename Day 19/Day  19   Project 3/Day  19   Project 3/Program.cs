using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day__19___Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:\\XMLFILES\\krish.Xml.Xml");

                //XmlNode node =Doc.DocumentElement.SelectSingleNode("\products\product");

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string text = node.InnerText;

                    Console.WriteLine(text);
                }

                Console.ReadLine();

            }
        }
    }
}
