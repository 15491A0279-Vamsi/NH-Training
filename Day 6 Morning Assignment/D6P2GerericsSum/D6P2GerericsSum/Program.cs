using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6P2GerericsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            int sum = 0;
            data.Add(5);
            data.Add(10);
            data.Add(15);
            data.Add(25);

            foreach (var d in data)
            {
                sum = sum + d;
            }

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
