using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3P4ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[5] {1,2,3,4,5};

            foreach(int d in data)
            {
                sum = sum + d;
                
            }
            Console.WriteLine("sum is:" + sum);

            Console.ReadLine();
            

        }
    }
}
