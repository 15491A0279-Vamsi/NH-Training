using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();

            data.Push(23);
            data.Push(28);
            data.Push(32);

          
            Console.WriteLine("Count:" + data.Count);
            Console.WriteLine("Peek:" + data.Peek());
            Console.WriteLine("Count:" + data.Count);
            Console.WriteLine("Pop:" + data.Pop());
            Console.WriteLine("Count:" + data.Count);

            Console.ReadLine();
        }
    }
}
