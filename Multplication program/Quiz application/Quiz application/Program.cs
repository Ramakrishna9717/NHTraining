using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter yur name");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0},Welcome to Quiz by Rk", name);


            Console.WriteLine("Q1 ,what is the captial og goa;");
            Console.WriteLine("1. panaji  2. hyderbad   3.skiiim  4.Mumbai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score+=20;

            Console.WriteLine("Q2 ,what is the captial of Nagaland;");
            Console.WriteLine("1. Gantok 2. hyderbad   3.kohima 4.Mumbai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score+=20;

            Console.WriteLine("Q3 ,what is the captial og Sikkim;");
            Console.WriteLine("1. Gantok 2. hyderbad   3.skiiim  4.Mumbai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score+=20;

            Console.WriteLine("Q4 ,what is the captial of assam;");
            Console.WriteLine("1. panaji  2. Dispur   3.skiiim  4.Mumbai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score+=20;

            Console.WriteLine("Q5 ,what is the captial of kerala;");
            Console.WriteLine("1. panaji  2. hyderbad   3.Thirvanthapuram  4.Mumbai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score+=20;

            if (score>=60)
                Console.WriteLine("Congratulations{0}, you got{1}% inthis quiz", name, score);
            else
                Console.WriteLine("sorry{0},ypou got only{1},try again", name,score);

            Console.ReadLine();


        }
    }
}
