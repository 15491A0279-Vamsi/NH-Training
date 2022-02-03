using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project2
{
    class MathTask
    {
        public int a;
        public int b;

        public void ReadInput()
        {
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());

        }

        public int AddNumbers()
        {
            return a + b;
        }

        public int SubstractNumbers()
        {
            return a - b;
        }

        public int MultiplyNumbers()
        {
            return a * b;
        }

        public float DivideNumbers()
        {
            return a / b;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTask mt = new MathTask();
            mt.ReadInput();
            Console.WriteLine(mt.AddNumbers());
            Console.WriteLine(mt.SubstractNumbers());
            Console.WriteLine(mt.MultiplyNumbers());
            Console.WriteLine(mt.DivideNumbers());
            

            Console.ReadLine();
        }
    }
}
