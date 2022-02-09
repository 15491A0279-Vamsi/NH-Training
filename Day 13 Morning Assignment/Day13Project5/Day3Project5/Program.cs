using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];

            //Read from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter first array value at {0},{1}:", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] b = new int[2, 2];

            //Read from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter second array value at {0},{1}:", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sum of Two 2D Arrays is :");

            int[,] result = new int[2, 2];

            //Print the values
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                    Console.Write(result[i, j] + " ");

                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
