using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project8
{
  
    internal class Program
    {
        
        static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any Number:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of {0} is {1}:", n,Factorial(n));

            Console.ReadLine();

        }
    }
}
