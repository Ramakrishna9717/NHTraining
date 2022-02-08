using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
   abstract class  salary
    {
        public int Getpf(int basic)
        {
            return 12* basic/100;
        }

        public int GetHRA(int basic)
        {
            return 40 *basic/100;
        }

        public abstract int GETCA();
        public abstract int GETSA();

    }
    class microsoft : salary
    {
        public override int GETCA()
        {
            return 6000;
        }

        public override int GETSA()
        {
            return 7000;
        }
    }
    class IBM : salary
    {
        public override int GETCA()
        {
            return 6000;

        }

        public override int GETSA()
        {
            return 4000;
        }
    }


    class Google :salary
    {
        public  override int GETCA()
        {
            return 1000;
        }
        public  override int GETSA()
        {
            return 1000;
        }
    }
    class Facebook : salary
    {
        public  override int GETCA()
        {
            return 1000;
        }
        public override int GETSA()
        {
            return 1000;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // microsoft
            //google
            //ibm
            //Facebook

            Console.WriteLine("completed processing");
            Console.ReadLine();

        }
    }
}
