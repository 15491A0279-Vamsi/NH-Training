using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2p6MultiplicationTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;

            Console.WriteLine("Enter a Number");
            input = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= 10; i++)
            {
                Console.WriteLine(input + "*" + i + "=" + input*i);

            }

            for (i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0}*{1} = {2}", input, i, input * i);
            }
            Console.ReadLine();
        }
    }
}
