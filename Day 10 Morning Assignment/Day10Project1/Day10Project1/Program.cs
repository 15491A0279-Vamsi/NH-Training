using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    class TotalMaths : Algebra
    {
        public int Mul(int a, int b)
        {
            return (a * b);
        }
    }

    class AllSubjects : TotalMaths
    {
        public string Water()
        {
            return "H2O";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalMaths tm = new TotalMaths();
            Console.WriteLine("Single Inheritance");
            Console.WriteLine("Addition: " + tm.Add(5,4));
            Console.WriteLine("Substraction: " + tm.Sub(5,4));
            Console.WriteLine("Multiplication: " + tm.Mul(5,4));

            Console.WriteLine("********************************************************************");
           

            AllSubjects al = new AllSubjects();
            Console.WriteLine("Multilevel Inheritance");
            Console.WriteLine("Addition: " + al.Add(5, 4));
            Console.WriteLine("Substraction: " + al.Sub(5, 4));
            Console.WriteLine("Multiplication: " + al.Mul(5, 4));
            Console.WriteLine("Water: " + al.Water());


            Console.ReadLine();

        }
    }
}
