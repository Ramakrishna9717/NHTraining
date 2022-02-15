using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rk_Library;

namespace public_Library
{
    public class MyPublicDerviedClass :MyBaseClass
    {
        public void MypublicDerviedClassMethod()
        {
            a=10;
            b=20;
            c=30;
            d=40;
            e=50;
        }
        
    }

    public class MyPublicOtherClass
    {
        public void MyPublicOtherclassMethod()
        {
            MyBaseClass mb =new MyBaseClass();
            mb.a= 10;
            mb.b= 20;
            mb.c= 30;
            mb.d= 40;
            mb.e= 50;
        }

    }
}
