using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3P3print4numbersusingForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Variable Declaration
            int sum = 0;
            int[] data = new int[4];

            //Read Data From User
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter Number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You Entered Numbers Are:");

            foreach (int d in data)
            {
                
                Console.WriteLine(d);
            }
            Console.ReadLine();

        }
    }
}
