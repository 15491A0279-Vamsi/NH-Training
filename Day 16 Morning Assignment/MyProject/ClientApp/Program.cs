using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamsiKrishnaLibrary;
using PublicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplication.Factorial(5));
            Console.WriteLine(Physics.FinalVelocity(5,2,3));
            Console.ReadLine();
        }
    }
}
