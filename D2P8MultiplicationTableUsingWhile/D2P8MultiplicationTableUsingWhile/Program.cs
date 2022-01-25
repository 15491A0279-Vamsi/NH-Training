using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P8MultiplicationTableUsingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i = 1;

            Console.WriteLine("Enter a Number");
            input = Convert.ToInt32(Console.ReadLine());

            while(i <= 10)
            {
                Console.WriteLine(input + "*" + i + "=" + input * i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
