using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project3
{
    internal class Program
    {
        class AverageSpeed
        {
            private int time;
            private int distance;

            public int Distance
            {
                set
                {
                    distance = value;    //Normal Properties
                }
            }

            public int Time
            {
                set
                {
                    time = value;                //Normal Properties
                }
            }

            public int Speed
            {
                get
                {
                    return distance / time;                //Auto-implemented Properties
                }
            }

            
        }
        static void Main(string[] args)
        {
            AverageSpeed avg = new AverageSpeed();
            avg.Distance = 70;
            avg.Time = 30;
            Console.WriteLine($"Average Speed is { avg.Speed}");

            Console.ReadLine();
        }
    }
}
