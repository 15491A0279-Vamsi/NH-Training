using System;

interface IRules
{
    
    public void PrintHi()
    {
        Console.WriteLine("Hi");
    }
}

class MyClass : IRules
{

}

class Program
{
    public static void Main(string[] args)
    {
        IRules obj = new MyClass();

        obj.PrintHi();

        Console.ReadLine();
    }
}
