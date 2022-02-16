using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                for (int i = 1; i <= n; i++)
                    fact = fact * i;
                return fact;

            }
        }

        public static bool IsPalindrome(int n)
        {
            int m, rem, rev = 0;

            Console.WriteLine("Enter any Number");
            n = Convert.ToInt32(Console.ReadLine());

            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;

            }
            if (n == rev)
            {
                return true;
            }
            else
            {
               return false;
            }

        }
    }
}
