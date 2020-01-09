using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many miles have you driven?: ");
           

            string mileage = Console.ReadLine();
            float miles = float.Parse(mileage);


            Console.Write("How many gallons of gas have you consumed? ");
            

            string gas = Console.ReadLine();
            float gallons = float.Parse(gas);
           
            

            float mpg = miles / gallons;

            Console.WriteLine("Your miles per gallon is: " + mpg);
            Console.ReadLine();
        }
    }
}
