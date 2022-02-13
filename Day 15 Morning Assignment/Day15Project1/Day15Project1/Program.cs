using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("E:\\Files\\Hello.txt", "E:\\Server\\Hello.txt");
            Console.WriteLine("File Copy Done");

            Console.ReadLine();

        }
    }
}
