using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("enter first number");
                a= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b= Convert.ToInt32(Console.ReadLine());
                c=a/b;
                Console.WriteLine(c);
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("only numbers between 0 and 50000");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("only numbers are allowed.please double check");
            }
            catch(Exception)
            {
                Console.WriteLine(" please  contact ABC@company");
            }

            Console.ReadLine();
        }
    }
}
