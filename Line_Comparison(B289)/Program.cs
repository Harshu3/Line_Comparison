using System;

namespace Line_Comparison
{
    internal class Program
    {
        public static void LengthOfLine()
        {
            Console.WriteLine("Enter First Point");
            Console.Write(" X1 = ");
            double x1 = double.Parse((Console.ReadLine()));
            Console.Write(" Y1 = ");
            double y1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Second Point");
            Console.Write("X2 = ");
            double x2 = double.Parse((Console.ReadLine()));
            Console.Write(" Y2 = ");
            double y2 = double.Parse((Console.ReadLine()));
            double LenghtOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.Write($"Lenght of a Line = {LenghtOfLine}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            LengthOfLine();
        }
    }
}