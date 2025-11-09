using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private Random _random = new Random();

    public void Start()
    {
        string input = "";
        while (input != "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n🌟 Level {_level} | Total Points: {_score}");
            Console.ResetColor();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus for completion: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet! Create one first.");
            return;
        }

        ListGoals();
        Console.Write("\nEnter the number of the goal you completed: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[choice].RecordEvent();
        _score += earned;

        DisplayRandomEncouragement();
        CheckLevelUp();

        Console.WriteLine($"\n🎉 You earned {earned} points!");
    }

    private void SaveGoals()
    {
        Console.Write("Enter file name to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine($"{_score},{_level}");
            foreach (Goal g in _goals)
                writer.WriteLine(g.GetStringRepresentation());
        }

        Console.WriteLine("✅ Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter file name to load: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("❌ File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        string[] header = lines[0].Split(",");
        _score = int.Parse(header[0]);
        _level = int.Parse(header[1]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                                             int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
        }

        Console.WriteLine("✅ Goals loaded successfully!");
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🏆 Congratulations! You reached Level {_level}!");
            Console.ResetColor();
        }
    }

    private void DisplayRandomEncouragement()
    {
        string[] messages = {
            "Keep up the great work!",
            "You're doing amazing!",
            "Small steps make big progress!",
            "Heavenly Father is proud of your efforts.",
            "Every goal achieved brings you closer to greatness!"
        };
        Console.WriteLine($"\n💬 {messages[_random.Next(messages.Length)]}");
    }
}
