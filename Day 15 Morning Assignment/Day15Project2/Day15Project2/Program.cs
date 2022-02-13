using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("E:\\Files\\Hello.txt",true);
            sw.WriteLine("Nations Benefits => NB Healthcare Technologies");
            sw.Close();

            Console.WriteLine("Written in File Done");
            Console.WriteLine("Append in a file is Done");
            

            Console.ReadLine();
        }
    }
}
