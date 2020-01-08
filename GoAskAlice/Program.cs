﻿using System;

namespace GoAskAlice
{
    class Program
    {
        private const string Alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";
        
        static void Main(string[] args)
        
        {
            // TODO: Prompt the user for a string within the first sentence of Alice in Wonderland to search for within this string.
            Console.WriteLine("Please enter a word or phrase from the first sentence of \"Alice In Wonderland\" and I will see if I can find it: ");
            string search = Console.ReadLine();

            Console.WriteLine(Match(search));
            Console.ReadLine();
        }

        public static bool Match(string search)
        {
            bool result = true;
            if (Alice.Contains(search, StringComparison.InvariantCultureIgnoreCase))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

    }

}
