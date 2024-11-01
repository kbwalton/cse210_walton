using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Eternal Quest Program ---");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Display goal details");
                Console.WriteLine("4. Display total score");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nChoose the type of goal:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.Write("Select an option: ");
                        string goalType = Console.ReadLine();

                        Console.Write("Enter the goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter a brief description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter the points for this goal: ");
                        int points = int.Parse(Console.ReadLine());

                        if (goalType == "1")
                        {
                            goalManager.CreateGoal(new SimpleGoal(name, description, points));
                        }
                        else if (goalType == "2")
                        {
                            goalManager.CreateGoal(new EternalGoal(name, description, points));
                        }
                        else if (goalType == "3")
                        {
                            Console.Write("Enter the target number of times to complete this goal: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Enter the bonus points for completing the goal: ");
                            int bonus = int.Parse(Console.ReadLine());
                            goalManager.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- List of Goals ---");
                        goalManager.ListGoalDetails();
                        Console.Write("Enter the number of the goal to record an event: ");
                        int goalIndex = int.Parse(Console.ReadLine());
                        goalManager.RecordEvent(goalIndex - 1); // index
                        break;

                    case "3":
                        Console.WriteLine("\n--- Goal Details ---");
                        goalManager.ListGoalDetails();
                        break;

                    case "4":
                        goalManager.DisplayPlayerInfo();
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
