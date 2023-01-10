using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1,100);
        
        // Console.Write("What is the magic number? ");
        // string answerStr = Console.ReadLine();
        // int answer = int.Parse(answerStr);
        
        string cont = "yes";
        
        while (cont == "yes")
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            int guess = int.Parse(guessStr);
            
            if (guess > answer)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < answer)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                cont = "no";
            }
        }
        
    }
}