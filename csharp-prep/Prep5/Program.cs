using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        //Ask for and return user's name as a string
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Ask for and return integer
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userNumStr = Console.ReadLine();
            int userNumber = int.Parse(userNumStr);
            return userNumber;
        }

        //Accept integer as parameter and return the integer squared
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        // Display the results of the functions above
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);

    }
}