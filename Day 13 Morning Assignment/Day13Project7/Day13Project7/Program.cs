using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];

            names[0] = new char[] { 'v', 'a', 'm', 's', 'i','k','r','i','s','h','n','a' };
            names[1] = new char[] { 'p', 'a', 'v', 'a', 'n' };
            names[2] = new char[] { 'm', 'a', 'n', 'o', 'j','k' };

            for(int i =0; i < 3; i++)
            {
                for(int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
