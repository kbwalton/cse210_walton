using System;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("Please enter the duration in seconds:");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_name} activity.");
        Console.WriteLine($"You did this activity for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);  
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
