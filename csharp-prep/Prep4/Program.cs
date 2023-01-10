using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        int sum = 0;
        int largestNumber = 0;

        do
        {
            Console.Write("Enter number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);

            numbers.Add(number);
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }

        } while (number != 0);
  
        Console.WriteLine($"The sum is: {sum}");

        int average = sum / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");
        
        // // Iterate through the list
        // foreach (int input in numbers)
        // {
        // Console.WriteLine(input);
        // }

        // // Access list items by thier index
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }

    }
}