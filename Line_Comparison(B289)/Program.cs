using System;

namespace Line_Comparison
{
    internal class Program
    {
        public static void LengthOfLine()
        {
            Console.WriteLine("Enter First line Point");
            Console.WriteLine("Enter First Point");
            Console.Write(" X1 = ");
            double x1 = double.Parse((Console.ReadLine()));
            Console.Write(" Y1 = ");
            double y1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Second Point");
            Console.Write(" X2 = ");
            double x2 = double.Parse((Console.ReadLine()));
            Console.Write(" Y2 = ");
            double y2 = double.Parse((Console.ReadLine()));
            double LenghtOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Lenght of First Line = {LenghtOfLine1}");

            Console.WriteLine(" Enter Second line point");
            Console.WriteLine("Enter First Point");
            Console.Write(" X3 = ");
            double x3 = double.Parse((Console.ReadLine()));
            Console.Write(" Y3 = ");
            double y3 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Second Point");
            Console.Write(" X4 = ");
            double x4 = double.Parse((Console.ReadLine()));
            Console.Write(" Y4 = ");
            double y4 = double.Parse((Console.ReadLine()));
            double LengthofLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine($"Length of Second Line = {LengthofLine2}");

            if (LenghtOfLine1 == LengthofLine2)
            {
                Console.WriteLine("First Line and Second Lines are Equal");
            }
            else
            {
                Console.WriteLine("First Line and Second Lines are not Equal");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            LengthOfLine();
        }
    }
}