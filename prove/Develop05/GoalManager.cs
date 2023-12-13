class GoalManager
{
    private List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("Choose the type of goal you want to create:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Enter your choice: ");

        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            switch (goalType)
            {
                case 1:
                case 2:
                    CreateSimpleOrEternalGoal(goalType);
                    break;
                case 3:
                    CreateChecklistGoal();
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please select a valid option.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    private void CreateSimpleOrEternalGoal(int goalType)
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description for the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points associated with this goal: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            if (goalType == 1)
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else
            {
                _goals.Add(new EternalGoal(name, description, points));
            }

            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid input. Points must be a valid number.");
        }
    }

    private void CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description for the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points associated with this goal: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            Console.Write("Enter the target number of times the goal is expected to be achieved: ");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                Console.Write("Enter the bonus points to be given when the target is achieved: ");
                if (int.TryParse(Console.ReadLine(), out int bonus))
                {
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    Console.WriteLine("Checklist goal created successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Bonus must be a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Target must be a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Points must be a valid number.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter the goal file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine($"Saving actual player points: {_score}");

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
{
    Console.Write("Enter the goal file name: ");
    string fileName = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine("This is the goal you have saved: ");

    try
    {
        using (System.IO.StreamReader file = new System.IO.StreamReader(fileName))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line); // Display each line as it is read
                ParseAndAddGoal(line);
            }
        }

        // Console.WriteLine("Goals loaded successfully!");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
}

    private void ParseAndAddGoal(string line)
    {
        string[] parts = line.Split(':');
        if (parts.Length >= 2)
        {
            string type = parts[0];
            string[] attributes = parts[1].Split(',');

            if (type.Equals("SimpleGoal") && attributes.Length == 4)
            {
                _goals.Add(new SimpleGoal(attributes[0], attributes[1], int.Parse(attributes[2])) { _isComplete = bool.Parse(attributes[3]) });
            }
            else if (type.Equals("EternalGoal") && attributes.Length == 3)
            {
                _goals.Add(new EternalGoal(attributes[0], attributes[1], int.Parse(attributes[2])));
            }
            else if (type.Equals("ChecklistGoal") && attributes.Length == 6)
            {
                _goals.Add(new ChecklistGoal(attributes[0], attributes[1], int.Parse(attributes[2]), int.Parse(attributes[4]), int.Parse(attributes[5])) { _amountCompleted = int.Parse(attributes[3]) });
            }
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Goals recorded:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal you accomplished: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            selectedGoal.RecordEvent();

            _score += selectedGoal._points;
            Console.WriteLine($"Congratulations! You have earned {selectedGoal._points} points.");

            Console.WriteLine($"You have now {_score} total points.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }
}