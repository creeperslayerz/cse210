using System;

class Program //While Loops and Random function
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string answerStr = Console.ReadLine();
        // int answer = int.Parse(answerStr);

        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1,100);
               
        string again = "yes";

        while (again == "yes")
        {

        
        
            string cont = "yes";
            int guessCount = 0;
            
            while (cont == "yes")
            {
                Console.Write("What is your guess? ");
                string guessStr = Console.ReadLine();
                int guess = int.Parse(guessStr);
                
                if (guess > answer)
                {
                    Console.WriteLine("Lower");
                    guessCount += 1;
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Higher");
                    guessCount += 1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessCount += 1;
                    cont = "no";
                }            
            }
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.WriteLine("Would you like to play again? yes/no");
            again = Console.ReadLine();
        }
    }
}