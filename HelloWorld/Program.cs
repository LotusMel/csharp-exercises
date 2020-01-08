using System;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Greeting();
            
        }

        public static void Greeting()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
    }
            
}
