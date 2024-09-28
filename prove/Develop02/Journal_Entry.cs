using System;

namespace JournalProgram
{
    public class JournalEntry
    {
        public string Prompt {get; set; }
        public string Response {get; set; }
        public DateTime Date {get; set; }

        public JournalEntry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - Prompt: {Prompt}\nResponse: {Response}\n";
        }
    }
}
