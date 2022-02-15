using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project6
{
    class MultiplicationTable
    {
        int input, i;
        public void ReadData()
        {
            Console.WriteLine("Enter a Number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            for (i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0}*{1} = {2}", input, i, input * i);
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable mt = new MultiplicationTable();
            mt.ReadData();
            Console.WriteLine("*******************************");
            mt.PrintData();

            Console.ReadLine();
        }
    }
}
