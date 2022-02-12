using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2
{
    sealed class Police
    {
        public static int helpLine = 100;

        public string GetSecret()
        {
            return "001";
        }
    }

    class Thief : Police
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Thief thief = new Thief();
            Console.WriteLine(Thief.GetSecret());

            Console.ReadLine();
        }
    }
}
