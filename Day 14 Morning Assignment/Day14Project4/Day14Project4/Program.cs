using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 43, i;
            for(i=2;i<n;i++)
            {
                if(n % i == 0)
                {
                    break;
                }
            }
            if(i == n)
            {
                Console.WriteLine($"Given Number {n} is Prime Number");
            }
            else
            {
                Console.WriteLine($"Given Number {n} is Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
