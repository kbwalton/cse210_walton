using System;
using System.Runtime.InteropServices;

namespace JournalProgram
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.Write("Set a 4 digit PIN to secure your journal entries: ");
            string pin = Console.ReadLine();
            while (pin.Length != 4 || !int.TryParse(pin, out _))
            {
                Console.WriteLine("Invalid PIN. Please enter a 4-digit number code. ");
                pin = Console.ReadLine();


            }
            Journal journal = new Journal(pin);
            PromptGenerator promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("\nJournal Menu: ");
                Console.WriteLine("1. Write a new journal entry");
                Console.WriteLine("2. Display all journal entries");
                Console.WriteLine("3. Display journal titles");
                Console.WriteLine("4. Save journal to file");
                Console.WriteLine("5. Load journal from file");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                      case "1":
                        string prompt = promptGenerator.GetPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();

                        Console.Write("Enter the date for the entry (MM/DD/YYYY): ");
                        DateTime entryDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out entryDate))
                        {
                            Console.WriteLine("Invalid date. Please enter a valid date (MM/DD/YYYY): ");
                        }

                        journal.AddEntry(prompt, response, entryDate);
                        break;

                    case "2":
                        Console.Write("Please enter your 4-digit PIN for access: ");
                        string enteredPin = Console.ReadLine();
                        journal.DisplayEntries(enteredPin);
                        break;

                    case "3": // New case for displaying journal titles
                        Console.Write("Please enter your 4-digit PIN to view journal titles: ");
                        enteredPin = Console.ReadLine();
                        journal.DisplayTitles(enteredPin); // Call the new method
                        break;

                    case "4":
                        Console.Write("Enter filename to save: ");
                        string saveFileName = Console.ReadLine();
                        Console.Write("Enter the date of the entries you want to save (MM/DD/YYYY): ");
                        DateTime saveDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out saveDate))
                        {
                            Console.WriteLine("Invalid date. Please enter a valid date (MM/DD/YYYY): ");
                        }
                        journal.SaveToFile(saveFileName, saveDate);
                        break;

                    case "5":
                        Console.Write("Enter filename to load: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        break;

                    case "6":
                        Console.WriteLine("Exiting the journal! Make good choices!");
                        return;

                    default:
                        Console.WriteLine("Invalid response.");
                        break;
                
                }
            }   
        }
    }
}