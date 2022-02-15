using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project7
{
    class PalindromeNumber
    {
        int n, m, rem, rev = 0;

        public void ReadData()
        {
            
            Console.WriteLine("Enter any Number");
            n = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData()
        {
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;

            }
            if (n == rev)
            {
                Console.WriteLine("{0} is Palindrome", n);
            }
            else
            {
                Console.WriteLine("{0} is Not a Palindrome", n);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumber pn = new PalindromeNumber();
            pn.ReadData();
            pn.PrintData();

            Console.ReadLine();
        }
    }
}
