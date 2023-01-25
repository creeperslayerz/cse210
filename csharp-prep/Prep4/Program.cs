using System.Collections.Generic;

class Program //do loop, lists, and some simple calculations
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        int sum = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = 1000000;

        do
        {
            Console.Write("Enter number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
            
            if (number > largestNumber)
            {
                largestNumber = number;
            }

        } while (number != 0); // Without the if statement on line 22, the 0 to quit the loop was still added to the list
  
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");

        foreach (int num in numbers)
        {
            if (num < smallestPositiveNumber && num > 0)
            {
                smallestPositiveNumber = num;
            } 
        }
        Console.WriteLine($"The smallest postive number is: {smallestPositiveNumber}");

        Console.WriteLine("The sorted list is:");
        // Sort the list
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
                
        // // Access list items by thier index
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }

    }
}