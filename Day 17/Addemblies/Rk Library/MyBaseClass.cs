using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rk_Library
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        internal protected int e;

        public void MybaseclassMethod()
        {
            a=10;
            b=20;
            c=30;
            d=40;
            e=50;
        }
    }
    public class MyDerviedClass :MyBaseClass
    {
        public void MyDerviedClassMethod()
        {
            a=10;
            b=20;
            c=30;
            d=40;
            e=50;
        }
    }
    public class MyOtherclass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            
               mb.a= 10;
               mb.b= 20;
               mb.c= 30;
               mb.d= 40;
               mb.e= 50;
                
        }
   
    }  
}
  


