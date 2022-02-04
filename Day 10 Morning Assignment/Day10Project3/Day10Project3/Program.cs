using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project3
{
    internal class Program
    {
        class EnglishMessage
        {
            public void PrintHi()
            {
                Console.WriteLine("Hi");
            }

            public void PrintHello()
            {
                Console.WriteLine("Hello");
            }

            public void PrintGm()
            {
                Console.WriteLine("Good Morning");
            }
        }

        class TeluguMessage : EnglishMessage
        {
            public new void PrintGm()
            {
                Console.WriteLine("Subodhayam");
            }
        }
        
        static void Main(string[] args)
        {
            TeluguMessage tl = new TeluguMessage();
            tl.PrintHi();
            tl.PrintHello();
            tl.PrintGm();

            Console.ReadLine();
        }
    }
}
