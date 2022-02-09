using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();

            data.Enqueue(23);
            data.Enqueue(28);
            data.Enqueue(32);


            Console.WriteLine("Count:" + data.Count);
            Console.WriteLine("Peek:" + data.Peek());
            Console.WriteLine("Count:" + data.Count);
            Console.WriteLine("Pop:" + data.Dequeue());
            Console.WriteLine("Count:" + data.Count);

            Console.ReadLine();
        }
    }
}
