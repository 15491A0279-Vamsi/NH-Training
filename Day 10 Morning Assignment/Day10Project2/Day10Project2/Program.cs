using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project2
{
    internal class Program
    {
        class ArithmeticOperation
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public int Add(int a, int b, int c, int d)
            {
                return a + b + c + d;
            }
        }
        
        
        static void Main(string[] args)
        {
            ArithmeticOperation op = new ArithmeticOperation();
            Console.WriteLine("sum: " + op.Add(1,2));
            Console.WriteLine("sum: " + op.Add(1, 2,3));
            Console.WriteLine("sum: " + op.Add(1, 2,3,4));

            Console.ReadLine();
        }
    }
}
