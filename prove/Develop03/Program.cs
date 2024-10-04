using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Joshua", 1, 9), "Have I not commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee withersoever thou goest"),
            
            new Scripture(new Reference("Enos", 1, 2), "And I will tell you of the wrestle which I had before God, before I recieved a remission of my sins"),
 
            new Scripture(new Reference("Psalm", 23, 1, 2), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."),

            new Scripture(new Reference("Alma", 37, 6, 7), "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise.")
        };

        
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords(3); 
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Well done!");
                break;
            }
        }
    }
}
