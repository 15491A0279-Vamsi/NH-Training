using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P3SumofNnaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, Sum = 0, i;

            Console.WriteLine("Enter a Number..");
            input = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= input; i++)
            {
                Sum = Sum + i;
            }
            Console.WriteLine(Sum);

            Console.ReadLine();
        }
    }
}
