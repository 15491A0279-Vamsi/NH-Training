using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6P3GenericUsingforforeachAndLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();

            data.Add("Vamsi");
            data.Add("Krishna");
            data.Add("Nations");
            data.Add("Benefits");

            //print values using for loop
            for(int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }

            //print values using foreach loop
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            //print values using lamda expression
            data.ForEach(p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
