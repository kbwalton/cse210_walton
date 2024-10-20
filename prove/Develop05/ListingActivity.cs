public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        ShowSpinner(3);

        List<string> responses = new List<string>();
        Console.WriteLine("Start listing your responses (type 'end' to stop):");
        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "end") break;
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
