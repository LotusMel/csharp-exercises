using System;
using System.Collections.Generic;

namespace StudentIdDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myStudents = new Dictionary<int, string>();
            int idNumber;

            Console.WriteLine("Enter an id number (or 0 to finish):");
            do
            {
                Console.Write("ID number: ");
                idNumber = int.Parse(Console.ReadLine());
                if (idNumber > 0)
                {
                    // Get the student's grade
                    Console.Write("student: ");
                    string student = Console.ReadLine();

                    myStudents.Add(idNumber, student);
                }   
            }
            while (idNumber > 0);

            // Print roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> myStudent in myStudents)
            {
                Console.WriteLine(myStudent.Key + ": " + myStudent.Value);
            }
            Console.ReadLine();

            
        }
    }
}
