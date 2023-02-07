using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        string theEnd = "";

        while(theEnd != "quit")
        {
            Scripture scripture = new Scripture();
            scripture.DisplayScripture();

            ListConverter listConverter = new ListConverter();
            listConverter.ConvertScriptureToList();
        
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to continue memorization exercise or type quit to be done. ");
            theEnd = Console.ReadLine();

            //TODO Make program end after all words are replaced with "___"
        }
        

        
    }
}