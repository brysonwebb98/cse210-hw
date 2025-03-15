using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("\n1. Create Goal\n2. View Goals\n3. Record Event\n4. Save\n5. Load Goals\n6. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ViewGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": 
                    GoalQuotes.DisplayRandomQuote();
                    running = false;
                    break;
                default: 
                    Console.WriteLine("Invalid option. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
    static void CreateGoal()
    {
        Console.Write("Type (1-Simple, 2-Eternal, 3-Checklist): ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        if (type == "1") goal = new SimpleGoal(name, desc, points);
        else if (type == "2") goal = new EternalGoal(name, desc, points);
        else if (type == "3")
        {
            Console.Write("Times required: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        if (goal != null) goals.Add(goal);
    }

    static void ViewGoals()
    {   
        Console.WriteLine("\nGoals:");
        int numGoals = 1;

        foreach (var goal in goals)
        {
            Console.Write($"{numGoals}. ");
            Console.WriteLine($"{goal.GetStatus()} {goal.Name} - {goal.Description}");
            numGoals += 1;
        }
        Console.WriteLine($"Total Score: {totalScore}");
        Console.ReadKey();
    }

    static void RecordEvent()
    {
        Console.Write("Enter goal name to record event: ");
        string name = Console.ReadLine();
        foreach (var goal in goals)
        {
            if (goal.Name == name)
            {
                goal.RecordEvent(ref totalScore);
                Console.WriteLine("Event recorded!");
                Console.ReadKey();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
        Console.ReadKey();
    }

    static void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(totalScore);

            while (goals.Count > 0)  
            {
                var goal = goals[0]; 
                file.WriteLine(goal.ToString());
                goals.RemoveAt(0); 
            }
        }
        totalScore = 0;
        Console.WriteLine($"Goals saved to {filename} and removed from the program!");
        Console.ReadKey();
    }
    static void LoadGoals()
    {
        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();  

        if (File.Exists(filename))  
        {
            string[] lines = File.ReadAllLines(filename);
            totalScore = int.Parse(lines[0]);

            goals.Clear();  

            foreach (string line in lines[1..]) 
            {
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                if (type == "SimpleGoal") 
                    goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                else if (type == "EternalGoal") 
                    goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                else if (type == "ChecklistGoal") 
                    goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
            }
            Console.WriteLine($"Goals loaded from {filename}!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Error: File not found.");
            Console.ReadKey();  
        }
    }
}