using System;
using System.Text;

namespace GradebookArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Allow for at most 30 students
            int maxStudents = 30;

            string[] students = new string[maxStudents];
            double[] grades = new double[maxStudents];

            string newStudent;
            int numStudents = 0;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students[numStudents] = newStudent;
                    numStudents++;
                }
            }
            while (newStudent != "" && numStudents < maxStudents);

            // Get student grades
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for " + students[i] + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades[i] = newGrade;
            }

            // Print class roster, summing grades as we go
            Console.WriteLine("\nClass roster:\n");

            StringBuilder roster = new StringBuilder(30);

            double sum = 0;

            for (int j = 0; j < numStudents; j++)
            {
                roster.AppendFormat("Student: {0}\nGrade: {1}\n\n", students[j], grades[j]);
                sum += grades[j];
            }

            Console.WriteLine(roster);
            double avg = sum / numStudents;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
