using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project4
{
    internal class Program
    {
        class EnglishMessage
        {
            public void PrintHi()
            {
                Console.WriteLine("***************Using Virtual-override***********************");
                Console.WriteLine("Hi");
            }

            public void PrintHello()
            {
                Console.WriteLine("Hello");
            }

            public virtual void PrintGm()
            {
                Console.WriteLine("Good Morning");
            }
        }

        class TeluguMessage : EnglishMessage
        {
            public override void PrintGm()
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
