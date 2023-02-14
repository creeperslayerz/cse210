using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Billy", "Backpacking");
        // assignment.SetStudentName("Billy");
        // assignment.SetTopic("Backpacking");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Bob", "Building", "Section 101", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Viola", "Fantasy", "Adventures of Evenlyn");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}