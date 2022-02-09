//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.WriteLine("Answer = {0}", c);

                Console.ReadLine();

            }
            catch(OverflowException)
            {
                Console.WriteLine("only numbers between 0 and 500000 are allowed");
                Console.ReadLine();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cannot divide with zero");
                Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("only numbers are entered,please double check");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("some error occured.contact admin@mycompany.com");
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\nDesigned by Vamsi Krishna");
                Console.ReadLine();
            }


            



        }
    }
}
