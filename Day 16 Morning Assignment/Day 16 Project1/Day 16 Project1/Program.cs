using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project1
{
    
    class Greetings
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings g = new Greetings();
            g.HelloWorld();

            Console.ReadLine();
        }
    }
}
