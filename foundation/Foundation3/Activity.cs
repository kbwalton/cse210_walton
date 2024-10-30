using System;

public class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string Date => date;
    public int Minutes => minutes;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{Date} Activity ({Minutes} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
