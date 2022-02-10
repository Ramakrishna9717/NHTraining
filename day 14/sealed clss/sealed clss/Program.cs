using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_clss
{
    sealed class police
    {
        public static int helpline = 101;
        public string GetSecret()
        {
           return "222" ;
        }
    }
    internal class Progra
    {
        static void Main(string[] args)
        {
            police p = new police();
            Console.WriteLine( p.GetSecret());
            Console.WriteLine(police.helpline);
            Console.ReadLine();
        }
    }
}
