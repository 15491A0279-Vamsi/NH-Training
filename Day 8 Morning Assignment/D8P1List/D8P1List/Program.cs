using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8P1List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 63, 22, 44, 56, 25, 46 };
            
            //for Loop Even Number
            for(int i = 0; i < data.Count; i++)
            {
                if(data[i] % 2 == 0)
                {
                    Console.WriteLine(data[i]);
                }
            }

            //foreach Loop for Even Number
            foreach(var d in data)
            {
                if(d % 2 == 0)
                {
                    Console.WriteLine(d);
                }
            }

            //lambda expression
            data.Where(d=>d%2==0).ToList().ForEach(d => Console.WriteLine(d));

            //Linq Query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();
        }
    }
}
