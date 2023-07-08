using System;

namespace Line_Comparison
{
    internal class Program
    {
        public class Line_Comparison1
        {
            public double LenghtofLine1;
            public double x1, x2, y1, y2;

            public Line_Comparison1()
            {
                Console.WriteLine("Enter First Line Point");
                Console.Write(" X1 = ");
                x1 = double.Parse((Console.ReadLine()));
                Console.Write(" Y1 = ");
                y1 = double.Parse((Console.ReadLine()));
                Console.WriteLine("Enter Second Point");
                Console.Write("X2 = ");
                x2 = double.Parse((Console.ReadLine()));
                Console.Write(" Y2 = ");
                y2 = double.Parse((Console.ReadLine()));
            }
            public double Line1()
            {
                return LenghtofLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }

        }

        public class Line_Comparison2 : Line_Comparison1
        {
            public double LenghtofLine2;
            public double x3, y3, x4, y4;

            public Line_Comparison2()
            {
                Console.WriteLine("Enter Second line point");
                Console.WriteLine("Enter First Point");
                Console.Write(" X3 = ");
                x3 = double.Parse((Console.ReadLine()));
                Console.Write(" Y3 = ");
                y3 = double.Parse((Console.ReadLine()));
                Console.WriteLine("Enter Second Point");
                Console.Write(" X4 = ");
                x4 = double.Parse((Console.ReadLine()));
                Console.Write(" Y4 = ");
                y4 = double.Parse((Console.ReadLine()));
            }
            public double Line2()
            {
                return LenghtofLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            }
        }

        public class Comparison : Line_Comparison2
        {

            public void lineCompare(double L1, double L2)
            {
                Console.WriteLine($"Length of line1 ={L1}");
                Console.WriteLine($"Length of line2 ={L2}");
                int Result = L1.CompareTo(L2);

                if (Result > 0)
                {
                    Console.WriteLine("First Line is Greater than Second Line");
                }
                else if (Result < 0)
                {
                    Console.WriteLine("Second Line is Greater than First Line");
                }
                else
                {
                    Console.WriteLine("First Line and Second Lines are Equal");
                }
            }
        }
        static void Main(string[] args)
        {
            Comparison Compare = new Comparison();
            Compare.lineCompare(Compare.Line1(), Compare.Line2());
        }
    }
}