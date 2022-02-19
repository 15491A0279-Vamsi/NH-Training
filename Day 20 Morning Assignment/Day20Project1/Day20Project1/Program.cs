using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project1
{
    public delegate void MyCaller(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc += Div;

            //12,6
            mc(12, 6);

            //20,10
            mc(20, 10);

            //16,8
            mc(16, 8);

            Console.WriteLine("****************After Removing Division Operation");

            mc -= Div;

            //6,3
            mc(6, 3);

            Console.ReadLine();
        }
    }
}
