using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3P2Array5numbersSumandAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int sum = 0;
            int[] data = new int[5]; 

            //Read Data From User
            for(int i=0; i<data.Length; i++)
            {
                Console.WriteLine("Enter Number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Logic
            for(int i = 0; i<data.Length;i++)
            {
                sum = sum + data[i];
            }

            //Output
            Console.WriteLine("Sum:" +sum);
            Console.WriteLine("Average :" + sum/5);

            Console.ReadLine();
        }
    }
}
