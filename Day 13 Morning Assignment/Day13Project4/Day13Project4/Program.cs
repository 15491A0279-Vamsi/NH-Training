using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];

            //Read from user
            for(int i =0; i < 2; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.WriteLine("Enter array value at {0},{1}:",i,j);
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print the values
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] + " ");  //Console.Write(); will print in same line.
                    
                }
                Console.WriteLine();
                Console.ReadLine();

                //Console.WriteLine(); will print in next line
                //or
                //Console.Write("/n"); will print in next line
            }
        }
    }
}
