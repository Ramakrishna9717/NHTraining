using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{ 
    interface Ishape
    {
        int Calculateperimeter();
        int Calculatearea();
    }
    class Circle : Ishape
    {
        int radius;
        public void Readdradius()
        {
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int Calculatearea()
        {
            return 22 * radius * radius / 7;
        }

        public int Calculateperimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : Ishape
    {
        int sides;
        public void Readsides()
        {
            Console.WriteLine("enter sides value");
            sides = Convert.ToInt32(Console.ReadLine());
        }
        public int Calculatearea()
        {
            return 4 * sides;
        }

        public int Calculateperimeter()
        {
            return sides * sides;
        }
    }

    class Rectangle : Ishape
    {
        int length, breadth;
        public void Readlength()
        {
            Console.WriteLine("enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
        }
        public int Calculatearea()
        {
            return 2*(length + breadth);
        }

        public int Calculateperimeter()
        {
            return length * breadth;
        }

    }
    class Triangle : Ishape
    {
            private int side1;
            public void readside1()
            {
                Console.WriteLine("enter side 1");
                side1 = Convert.ToInt32(Console.ReadLine());
            }
            private int side2;
            public void readside2()
            {
                Console.WriteLine("enter side 2");
                side2 = Convert.ToInt32(Console.ReadLine());
            }
            private int side3;
            public void readside3()
            {
                Console.WriteLine("enter side 3");
                side3 = Convert.ToInt32(Console.ReadLine());
            }

            public int Calculatearea()
            {
                float s = (side1+ side2+side3)/2;
                int area = (int)Math.Sqrt((s*(s-side1)*(s-side2)*(s-side3)));
                return area;

            }

            public int Calculateperimeter()
            {
                return side1 + side2 + side3;
            }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.Readdradius();
                Console.WriteLine(c.Calculatearea());
                Console.WriteLine(c.Calculateperimeter());

                Square s = new Square();
                s.Readsides();
                Console.WriteLine(s.Calculatearea());
                Console.WriteLine(s.Calculateperimeter());


                Rectangle r = new Rectangle();
                r.Readlength();
                Console.WriteLine(r.Calculatearea());
                Console.WriteLine(r.Calculateperimeter());
               

                Triangle t = new Triangle();
                t.readside1();
                t.readside2();
                t.readside3();
                Console.WriteLine(t.Calculatearea());
                Console.WriteLine(t.Calculateperimeter());

                Console.ReadLine();

            }
     }
} 