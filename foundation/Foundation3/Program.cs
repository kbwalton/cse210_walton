using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 45, 12.0),
            new Swimming("03 Nov 2022", 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
