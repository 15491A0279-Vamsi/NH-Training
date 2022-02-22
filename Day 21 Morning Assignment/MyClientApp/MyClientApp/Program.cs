using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClientApp.ServiceReference1;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraSoapClient obj = new AlgebraSoapClient();

            Console.WriteLine(obj.Factorial(5));
            Console.WriteLine(obj.Div(12,6));
            

            Console.ReadLine();
        }
    }
}
