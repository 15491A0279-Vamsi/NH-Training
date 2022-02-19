using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Update(out int a)
        {
            a = 10;
        }
        public static void Change(ref int d)
        {
            d = 11;
        }
        static void Main(string[] args)
        {
            int b;
            int c = 9;
            Program p1 = new Program();
            Update(out b);
            Change(ref c);
            Console.WriteLine("Updated value is: {0}", b);
            Console.WriteLine("Changed value is: {0}", c);
            Console.ReadLine();
        }
    }
}
