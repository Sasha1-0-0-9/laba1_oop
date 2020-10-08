using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle();
            Triangle.Output(abc.SideA, abc.SideB, abc.SideC);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Input new length for side A");
            abc.SideA = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Input new length for side B");
            abc.SideB = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Input new length for side C");
            abc.SideC = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
