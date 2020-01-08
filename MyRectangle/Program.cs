using System;

namespace MyRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! I'm here to help you find the area of a rectangle. " +
                "Press 'Enter' to begin.");
            Console.ReadLine();

            Rectangle();
        }

        public static void Rectangle()
        {
            Console.Write("Enter the length of your rectangle: ");
            float length = float.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            float height = float.Parse(Console.ReadLine());

            float area = length * height;

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
