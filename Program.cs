using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the coordinates of point A:");
            double ax = double.Parse(Console.ReadLine());
            double ay = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point B:");
            double bx = double.Parse(Console.ReadLine());
            double by = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point C:");
            double cx = double.Parse(Console.ReadLine());
            double cy = double.Parse(Console.ReadLine());

            
            double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double ac = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));

            
            bool isEquilateral = ab == ac && ac == bc;

            
            bool isIsosceles = ab == ac || ac == bc || ab == bc;

            
            double delta = 0.0001; // choose your own precision
            bool isRight = Math.Abs(Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ac, 2))) <= delta;

            
            double perimeter = ab + ac + bc;

            
            Console.WriteLine($"Side AB length: {Math.Round(ab, 2)}");
            Console.WriteLine($"Side AC length: {Math.Round(ac, 2)}");
            Console.WriteLine($"Side BC length: {Math.Round(bc, 2)}");
            Console.WriteLine($"Is it an equilateral triangle? {isEquilateral}");
            Console.WriteLine($"Is it an isosceles triangle? {isIsosceles}");
            Console.WriteLine($"Is it a right triangle? {isRight}");
            Console.WriteLine($"Perimeter: {Math.Round(perimeter, 2)}");

            
            Console.WriteLine("Even numbers from 0 to perimeter:");
            for (int i = 0; i <= perimeter; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}