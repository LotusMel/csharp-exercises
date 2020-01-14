using System;
using System.Collections.Generic;

namespace StringList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWords = new List<string>() { "Melie", "soda", "vernacular", "spaghetti", "write" };
            PentaScribe(myWords);
        }

        public static void PentaScribe(List<string> words)
        {

            foreach (string word in words)
            {
                if (word.Length == 5)
                    Console.Write(word + " ");
            }
            Console.ReadLine();
        }
    }
}
