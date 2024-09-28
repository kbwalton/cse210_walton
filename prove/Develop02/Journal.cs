using System;
using System.Collections.Generic;

namespace JournalProgram
{
    public class Journal
    {
        private List<JournalEntry> entries;
        private string pin; // Store the PIN here

        public Journal(string pin) // Constructor takes the pin
        {
            entries = new List<JournalEntry>();
            this.pin = pin;
        }

        public void AddEntry(string prompt, string response, DateTime date)
        {
            JournalEntry entry = new JournalEntry(prompt, response, date);
            entries.Add(entry);
        }

        public bool ValidatePin(string inputPin)
        {
            return inputPin == pin; // Check if the input PIN matches the stored PIN
        }

        public void DisplayEntries(string inputPin)
        {
            if (ValidatePin(inputPin)) // Validate the PIN
            {
                if (entries.Count == 0)
                {
                    Console.WriteLine("No entries found.");
                }
                else
                {
                    foreach (var entry in entries)
                    {
                        Console.WriteLine(entry);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Access denied.");
            }
        }
        public void DisplayTitles(string inputPin)
        {
            if (ValidatePin(inputPin))
            {
                if (entries.Count == 0)
                {
                    Console.WriteLine("No journal titles found.");
                }
                else
                {
                    Console.WriteLine("Journal Titles:");
                    foreach (var entry in entries)
                    {
                        Console.WriteLine($"- {entry.Prompt} (Date: {entry.Date.ToShortDateString()})");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Access denied.");
            }
        }

        public void SaveToFile(string filename, DateTime date)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename, append: true))
            {
                foreach (var entry in entries)
                {
                    if (entry.Date.Date == date.Date) // Save only entries for the specific date
                    {
                        writer.WriteLine(entry.Prompt);
                        writer.WriteLine(entry.Response);
                        writer.WriteLine($"Date: {entry.Date.ToShortDateString()}");
                    }
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            entries.Clear();
            if (System.IO.File.Exists(filename))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string prompt = reader.ReadLine();
                        string response = reader.ReadLine();
                        string dateLine = reader.ReadLine();
                        DateTime date = DateTime.Parse(dateLine.Replace("Date: ", ""));
                        entries.Add(new JournalEntry(prompt, response, date));
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found. Starting with an empty journal.");
            }
        }
    }
}
