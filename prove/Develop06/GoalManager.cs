using System;
using System.Collections.Generic;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public void Start()
        {
            // Code to initialize the program
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {_score}");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        public void CreateGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex < 0 || goalIndex >= _goals.Count)
            {
                Console.WriteLine("Invalid goal index.");
                return;
            }

            Goal goal = _goals[goalIndex];
            int pointsEarned = goal.RecordEvent();

            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");
        }

        public void SaveGoals()
        {
            // Code to save goals to a file
        }

        public void LoadGoals()
        {
            // Code to load goals from a file
        }
    }
}
