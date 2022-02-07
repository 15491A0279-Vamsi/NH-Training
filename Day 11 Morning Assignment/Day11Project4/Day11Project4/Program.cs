using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project4
{
    class Employee
    {
        public int id;
        public string name;
        public static string company = "NationsBenefits";
    }

    class Mathematics : Employee
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static void PrintCompany()
        {
            Console.WriteLine(company);
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }




    }
    
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(22,65));
            Console.WriteLine(Mathematics.Multiplication(22, 65));
            Mathematics.Hello();
            Mathematics.PrintCompany();

            Console.ReadLine();
        }
    }
}
