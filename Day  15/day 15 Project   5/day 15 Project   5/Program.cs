using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15_Project___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter swr = new StreamWriter("D:\\rama\\netproject\\Day  15\\File copy\\Hello.text");

            int score = 0, ans;
            String name;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Hi {0}, Welcome to the quiz by Rk", name);
           
            swr.WriteLine(name);



            Console.WriteLine("Q1.Who won the 2021 IPL Championship? ");
            Console.WriteLine("1.CSK  2 .DELHI  3.MUMBAI   4.SRH");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            Console.ReadLine();



            Console.WriteLine("Q2.Which TEAM Qualify more times sfor playoffs ");
            Console.WriteLine("1.DElhi 2 .CSk  3.MUMBAI   4.SRH");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            Console.ReadLine();



            Console.WriteLine("Q3.What is the Captian of CSK  Team ");
            Console.WriteLine("1.MSD 2.KOHLI  3.Sachin   4.Rohit");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            Console.ReadLine();


            Console.WriteLine("Q4.Who is the only batsman to record highest individual  Score in ipl? ");
            Console.WriteLine("1.Don Bradman  2.ABD  3 .gayle   4.Steve smith");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.ReadLine();


            Console.WriteLine("Q5. Who is known as MR,IPL");
            Console.WriteLine("1.Hadrik pandya  2.Rishab pant  3.Suresh Raina   4.K L Rahul");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;


            swr.WriteLine(score);
            swr.Close();

            Console.WriteLine("Thank you for taking the quiz,Please Contact admin can show your result");


            Console.ReadLine();
        }
    }
}




    