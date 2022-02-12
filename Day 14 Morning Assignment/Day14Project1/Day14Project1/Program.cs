using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1
{
    sealed class Police
    {
        public static int helpLine = 100;

        public string GetSecret()
        {
            return "001";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Police p = new Police();
            Console.WriteLine(Police.helpLine);
            Console.WriteLine(p.GetSecret());

            Console.ReadLine();
        }
    }
}
