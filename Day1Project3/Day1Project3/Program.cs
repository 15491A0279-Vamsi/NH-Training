using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            int p = 1;
            fn = 50;

            Console.WriteLine("Enter First Number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sn; i++)
                p = p * fn;

            Console.WriteLine("Power =" + p);

            Console.ReadLine();
        }
    }
}
