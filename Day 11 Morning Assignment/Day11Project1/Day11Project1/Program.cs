using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.WriteLine("Enter Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7; 
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
         }
    }

    class Square : IShape
    {
        private int side;

        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return side * side;
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }
    }

    class Triangle : IShape
    {
        private int side1,side2,side3;
        double semiPerimeter;


        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side:");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side:");
            side3 = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            semiPerimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return Convert.ToInt32(Area);
        }

        public int CalculatePerimeter()
        {
            return (side1 + side2 + side3);
        }
    }

    class Rectangle : IShape
    {
        private int length,width;

        public void ReadSide()
        {
            Console.WriteLine("Enter length:");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return length * width;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalculatePerimeter());
            Console.WriteLine(c.CalculateArea());

            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.CalculatePerimeter());
            Console.WriteLine(s.CalculateArea());

            Triangle t = new Triangle();
            t.ReadSide();
            Console.WriteLine(t.CalculatePerimeter());
            Console.WriteLine(t.CalculateArea());

            Rectangle r = new Rectangle();
            r.ReadSide();
            Console.WriteLine(r.CalculatePerimeter());
            Console.WriteLine(r.CalculateArea());

            Console.ReadLine();
        }
    }
}
