using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0,ans;
            string name;
            name =Console.ReadLine();

            Console.WriteLine("Hi{0},welcome to quiz by ramakrishna", name);

            Console.WriteLine("what is captial of haryan:");
            Console.WriteLine(" 1.Hyderbad 2.Chennai 3.Chandiarh 4.Mumnai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans==3)
                score+=20;


            Console.WriteLine("what is captial of skim:");
            Console.WriteLine(" 1.gantok 2.Chennai 3.Chandiarh 4.Mumnai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans==1)
                score+=20;

            Console.WriteLine("what is captial of nagaland:");
            Console.WriteLine(" 1.Hyderbad 2kohima3.Chandiarh 4.Mumnai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans==2)
                score+=20;

            Console.WriteLine("what is captial of goa:");
            Console.WriteLine(" 1.Hyderbad 2.Chennai 3.Chandiarh 4.panaji");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans==4)
                score+=20;

            Console.WriteLine("what is captial of Kerala:");
            Console.WriteLine(" 1.Hyderbad 2.Chennai 3.Trivanthaouram4.Mumnai");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans==3)
                score+=20;


            if (score>=60)
                Console.WriteLine("congratulations{0},you got only{1}% inthis quiz", name, score);
            else
                Console.WriteLine("score{0},you got only{1}%.try again",name, score);

            Console.ReadLine();


        }
    }
}
