using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rk_libray
{
    public class mathamatics
    {
        public int Factorial(int n)
        {
            int fact = 1;
            
            for (int i = 1; i<=n; i++)
                fact = fact*i;
            return fact;

        }
        public int add(int a, int b)
        {
            return a + b;

        }
        public int mul(int a, int b)
        {
            return a* b;
        }
}   }
