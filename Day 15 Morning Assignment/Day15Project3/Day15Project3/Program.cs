using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;

            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();

            Console.WriteLine("****************************************************");
            Console.WriteLine("Hi {0}, Welcome to Quiz By Vamsi", name);
            Console.WriteLine("****************************************************");

            Console.WriteLine("Q1. What is the capital of Andhra Pradesh:");
            Console.WriteLine("1.Amaravati 2.Vizag 3.Kurnool 4.Guntur");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            Console.WriteLine("Q2. Who is the CEO of Microsoft:");
            Console.WriteLine("1.Bill Gates 2.Sundar Pichai 3.Satya Nadella 4.Brian Humphries");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.WriteLine("Q3. Who is the CEO of Alphabet:");
            Console.WriteLine("1.Bill Gates 2.Sundar Pichai 3.Satya Nadella 4.Brian Humphries");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            Console.WriteLine("Q4. Who is the CEO of Cognizant:");
            Console.WriteLine("1.Bill Gates 2.Julie Sweet 3.Satya Nadella 4.Brian Humphries");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;

            Console.WriteLine("Q5. Who is the CEO of Nations Benefits:");
            Console.WriteLine("1.Michael Parker 2.Glenn Parker 3.Julie Sweet 4.Brian Humphries");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            StreamWriter sw = new StreamWriter("E:\\Files\\Hello.txt");
            
            sw.WriteLine("Name : {0}, Score : {1}", name, score);
            sw.Close();

            Console.WriteLine("Your Results are stored in our Database, and Admin will Let You Know The score");

            Console.ReadLine();
        }
    }
}
