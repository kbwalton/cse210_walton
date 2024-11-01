using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            int points = _goals[goalIndex].GetPoints();
            _score += points;
            Console.WriteLine($"Recorded {points} points for {_goals[goalIndex].GetDetailsString()}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals()
    {
        
    }

    public void LoadGoals()
    {
        
    }
}

