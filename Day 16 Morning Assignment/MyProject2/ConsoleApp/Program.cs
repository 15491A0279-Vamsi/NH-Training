using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamsiKrishnaLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Multiplication.Add(8,9));
            Console.WriteLine(Multiplication.Mul(8, 9));
            Console.WriteLine(Multiplication.Division(6,3));
            Console.ReadLine();

        }
    }
}
