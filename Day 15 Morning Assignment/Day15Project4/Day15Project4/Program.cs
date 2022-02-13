using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("File Created Time:");
            Console.WriteLine(File.GetCreationTime("E:\\Files\\Hello.txt"));
            StreamReader sr = new StreamReader("E:\\Files\\Hello.txt");
            string data = sr.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            Console.WriteLine("/************** File Reading Done ******************/");
            Console.ReadLine();

        }
    }
}
