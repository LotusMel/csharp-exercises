using System;
using System.Collections.Generic;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> freakyInts = new List<int>() { 1, 2, 4, 5, 7, 9, 11, 14, 16, 21, 24, 32};
            FindEvens(freakyInts);
            
        }

        public static void FindEvens(List<int> myInts)
        {
            int sum = 0;
            for (int i = 0; i < myInts.Count; i++)
            {
                if (myInts[i] % 2 == 0)
                {
                    sum += myInts[i];
                }
            }
            Console.WriteLine("The sum of all the even numbers in my list is {0}.", sum);
            Console.ReadLine();
        }
    }
}
