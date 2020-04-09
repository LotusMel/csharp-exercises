using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student girl1 = new Student();
            girl1.Name = "Emma";
            Console.WriteLine(girl1.Name);
            Console.ReadLine();
        }
    }

    public class Student
    {
        //private string name;
        //private int studentid;
        //private int numberofcredits = 0;
        //private double gpa = 0;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

    }
}
