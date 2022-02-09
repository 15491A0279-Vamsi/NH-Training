using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 55,23,4}, { 58,36,56}, { 89,47,23} };

            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum + data[i, j];
                    }
                }
                
            }
            Console.WriteLine("Sum :" + sum);
            Console.ReadLine();
        }
    }
}
