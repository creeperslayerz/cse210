using System;

class Program //if and else if (conditionals)
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

        string gradeSign = "";

        if (gradePercentageNumber >= 70 && gradePercentageNumber <= 97)
        {
            int gradeRemainder = gradePercentageNumber % 10;
        
            if (gradeRemainder >= 7)
            {
                gradeSign = "+";
            }
            else if (gradeRemainder < 3)
            {
                gradeSign = "-";
            }
        } 
        
        Console.WriteLine($"Your grade is {letter}{gradeSign}");

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