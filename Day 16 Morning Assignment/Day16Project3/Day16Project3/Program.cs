using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamsiLibrary;

namespace Day16Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());

            Console.WriteLine("**************************************");

            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetWater());
            Console.WriteLine(c.GetWater());
            Console.WriteLine(c.GetMethane());

            Console.WriteLine("**************************************");

            int u = 5;
            int a = 10;
            int t = 8;
            Physics p = new Physics();
            Console.WriteLine(p.FinalVelocity(u,a,t));

            //We can access methods using class name , by declaring methods and classes of library class as static without using objects


            Console.ReadLine();
        }
    }
}
