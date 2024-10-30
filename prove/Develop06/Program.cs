using System;

namespace EternalQuest
{
    public class Program
    {
        public static void Main()
        {
            GoalManager goalManager = new GoalManager();

            // Example of adding goals
            goalManager.CreateGoal(new SimpleGoal("Run Marathon", "Complete a marathon race", 1000));
            goalManager.CreateGoal(new EternalGoal("Read Scriptures", "Daily scripture reading", 100));
            goalManager.CreateGoal(new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500));

            // List goals
            goalManager.ListGoalNames();

            // Record progress
            Console.WriteLine("\nRecording progress on goals:");
            goalManager.RecordEvent(0); 
            goalManager.RecordEvent(1); 
            goalManager.RecordEvent(2); 

            // Display score
            goalManager.DisplayPlayerInfo();
        }
    }
}
