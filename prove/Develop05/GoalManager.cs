using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    class GoalManager
    {
        private List<Goal>goals = new List<Goal>();
        private int userScore = 0;

        public void CreateNewGoal()
        {
            Console.WriteLine("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("Choose goal type (1.Simple, 2.Eternal, 3.CheckList): ");
            if (int.TryParse(Console.ReadLine(), out int goalType))
            {
                Console.Write("What is the amount of points associated with this goal? ");
                if (int.TryParse(Console.ReadLine(), out int goalValue))
                {
                    Goal newGoal;

                    switch (goalType)
                    {
                        case 1:
                            newGoal = new SimpleGoal(goalDescription, goalValue);
                            break;
                        case 2:
                            newGoal = new EternalGoal(goalDescription, goalValue);
                            break;
                        case 3:
                            Console.Write("Enter required Events for checklist goal: ");
                            if (int.TryParse(Console.ReadLine(), out int requiredEvents))
                            {
                                newGoal = new CheckListGoal(goalDescription, goalValue, requiredEvents);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for required events. Goal creation failed.");
                                return;
                            }

                            goals.Add(newGoal);
                            Console.WriteLine("Goal created succesfully.");  
                    }
                }
            }
        }
        public void RecordEvent()
        {
            Console.WriteLine("\nRecording an event for a goal:");
        }

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events. Create goals first.");
            return;
        }

        Console.WriteLine("Choose a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. ");
            goals[i].Display();
            Console.WriteLine();
        }

        int choice;
        do
        {
            Console.Write("Enter your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > goals.Count);

        goals[choice - 1].RecordEvent();
        userScore += goals[choice - 1].GoalValue;
    }

    public void ListGoals()
    {
        Console.WriteLine("\nList of Goals:");
        foreach (var goal in goals)
        {
            goal.Display();
            Console.WriteLine();
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"\nYour current score: {userScore} points");
    }

    public void SaveGoalsAndScore()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.GoalDescription},{goal.Completed},{goal.GoalValue}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.RequiredEvents},{checklistGoal.CompletedEvents}");
                }
            }

            writer.WriteLine($"Score,{userScore}");
        }

        Console.WriteLine("\nGoals and score saved successfully.");
    }

    public void LoadGoalsAndScore()
    {
        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                goals.Clear();

                while (!reader.EndOfStream)
                {
                    string[] goalData = reader.ReadLine().Split(',');

                    switch (goalData[0])
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(goalData[1], int.Parse(goalData[3])) { Completed = bool.Parse(goalData[2]) });
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(goalData[1], int.Parse(goalData[3])) { Completed = bool.Parse(goalData[2]) });
                            break;
                        case "ChecklistGoal":
                            int requiredEvents = int.Parse(goalData[4]);
                            int completedEvents = int.Parse(goalData[5]);
                            goals.Add(new ChecklistGoal(goalData[1], int.Parse(goalData[3]), requiredEvents)
                            {
                                Completed = bool.Parse(goalData[2]),
                                CompletedEvents = completedEvents
                            });
                            break;
                    }
                }
            }
        }
    }
}