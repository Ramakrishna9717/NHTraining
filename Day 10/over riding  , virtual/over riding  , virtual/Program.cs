using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over_riding____virtual
{
    public class  abc
    {
        public  virtual int data(int a,int b)
        {
            return a + b;
        }
    }
    public class pqr :abc
    {
        public  override int data(int a ,int b)
        {
            return(a + b)*2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            pqr pqr = new pqr();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
