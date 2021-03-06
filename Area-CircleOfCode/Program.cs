﻿using System;

namespace Area_CircleOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of your circle: ");
            double myRadius = double.Parse(Console.ReadLine());
            Area.AreaOfCircle(myRadius);
        }

        public class Area
        {
            public static void AreaOfCircle(double radius)
            {
                double area = Math.PI * (radius * radius);
                while (radius > 0)
                {
                    Console.Write("The area of your circle is " + area);
                    Console.ReadLine();
                    break;
                }

                if (radius < 0)
                {
                    Console.WriteLine("Sorry. You must use a positive number. Try again: ");
                    double tryAgain = double.Parse(Console.ReadLine());
                    AreaOfCircle(tryAgain);
                }
                
                


            }
        }
    }
}
