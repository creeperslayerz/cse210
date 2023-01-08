using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string gradePercentageString = Console.ReadLine();
        int gradePercentageNumber = int.Parse(gradePercentageString);

        string letter = "";

        if (gradePercentageNumber >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageNumber >= 80 && gradePercentageNumber < 90)
        {
            letter = "B";
        }
        else if (gradePercentageNumber >= 70 && gradePercentageNumber < 80)
        {
            letter = "C";
        }
        else if (gradePercentageNumber >= 60 && gradePercentageNumber < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradePercentageNumber >= 70)
        {
            Console.WriteLine("Congratulations!");
        }
        else if (gradePercentageNumber < 70)
        {
            Console.WriteLine("Repetition is the key to learning!");
        }
    }
}