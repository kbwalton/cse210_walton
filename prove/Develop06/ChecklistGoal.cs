using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override int RecordEvent()
        {
            _amountCompleted++;
            int pointsGained = _points;

            if (_amountCompleted == _target)
            {
                pointsGained += _bonus;
                Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus of {_bonus} points!");
            }

            return pointsGained;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} - {_description} (Completed {_amountCompleted}/{_target})";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
        }
    }
}
