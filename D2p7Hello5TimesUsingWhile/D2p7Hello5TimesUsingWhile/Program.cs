using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2p7Hello5TimesUsingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i =1;

            Console.WriteLine("Enter a Number");
            input = Convert.ToInt32(Console.ReadLine());


            while(i <= input)
            {
                Console.WriteLine("Hello");
                i++;
            }

            Console.ReadLine();
        }
    }
}
