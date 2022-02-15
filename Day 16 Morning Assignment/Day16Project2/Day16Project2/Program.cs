using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    class Mathematics
    {
        int input;

        public int ReadData()
        {
            Console.WriteLine("Enter any Number:");
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public int GetFactorial()
        {
            int fact = 1;
            for(int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int input = m.ReadData();
            int Result = m.GetFactorial();
            Console.WriteLine("Factorial of {0} is :{1}", input, Result);
            Console.ReadLine();
        }
    }
}
