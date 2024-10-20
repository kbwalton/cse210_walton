public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        
        int cycleTime = 8;  
        int cycles = _duration / cycleTime;  

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4); 
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);  
        }

        int remainingTime = _duration % cycleTime; 
        if (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(remainingTime / 2);  
            Console.WriteLine("Breathe out...");
            ShowCountDown(remainingTime / 2);  
        }

        DisplayEndingMessage();
    }
}
