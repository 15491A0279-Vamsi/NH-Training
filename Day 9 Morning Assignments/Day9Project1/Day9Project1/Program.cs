using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project1
{
    class MathsOperations
    {
        private int input;

        public void ReadInput()
        {
            Console.WriteLine("Enter Number:");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void Factorial()
        {
            int fact = 1;
            for(int i =1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact); 
        }

        public void PrintFactors()
        {
            for(int i = 1; i <= input; i++)
            {
                if(input % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public bool isPrime()
        {
            int count = 0;
            for(int i = 1; i <=input; i++)
            {
                if(input % i == 0)
                    count++;
            }
            if(count == 2)
                return true;
            else
                return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations obj = new MathsOperations();
            obj.ReadInput();
            obj.Factorial();
            obj.PrintFactors();
            if (obj.isPrime())
                Console.WriteLine("input is prime numner");
            else
                Console.WriteLine("input is not a prime number");

            Console.ReadLine();
        }
    }
}
