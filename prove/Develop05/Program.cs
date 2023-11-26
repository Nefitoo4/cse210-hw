using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Develop05
{
    class Program
    {
        private static List<Goal> goals = new List<Goal>();
        private static int userScore = 0;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                //Display the menu and get the user's choice
                choice = Menu.ShowMenu();

                //Perform actions based on user's choice
                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoalsAndScore();
                        break;
                    case 4:
                        LoadGoalsAndScore();
                        break;
                    case 5:
                        RecordEvents();
                        break;
                    case 6:
                        //Quit the program
                        break;
                }
            }while(choice != 6);
        }

        //Methods
        private static void CreateNewGoal()
        {
            Console.Write("Enter goal description: ");
            string goalName = Console.ReadLine();

            Console.Write("Enter a short description of the goal: ");
            string goalDescription = Console.ReadLine();

            Console.Write("Enter the amount of points associated with this goal: ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
            Console.WriteLine("Choose goal type:");
            Console.WriteLine("Enter 1 for Simple)");
            Console.WriteLine("Enter 2 for Eternal)");
            Console.WriteLine("Enter 3 for Checklist)");

            if(int.TryParse(Console.ReadLine(), out int goalType))
            {
                Goal newGoal;

                switch(goalType)
                {
                    case 1:
                        newGoal = new SimpleGoal(goalDescription, points);
                        break;
                    case 2:
                        newGoal = new EternalGoal(goalDescription, points);
                        break;
                    case 3:
                        Console.Write("Enter required events for  the checklist goal: ");
                        if(int.TryParse(Console.ReadLine(), out int requiredEvents))
                        {
                            newGoal = new ChecklistGoal(goalDescription, points, requiredEvents);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for required events. Goal creation failed.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. Goal creation failed.");
                        return;
                    }
                    goals.Add(newGoal);
                    Console.WriteLine("Goal created successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid goal type. Goal creation failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for points. Goal creation failed.");
            }
        }
        private static void RecordEvents()
        {
            Console.WriteLine("\nRecording events for goals:");

            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available to record events. Create goals first.");
                return;
            }

            int goalIndex;
            do
            {
                Console.Write("Enter the number of the goal: ");
            }while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > goals.Count);

            userScore += goals[goalIndex - 1].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }

        private static void ListGoals()
        {
            Console.WriteLine("\nList of Goals:");
            foreach (var goal in goals)
            {
                goal.Display();
                Console.WriteLine("");
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        private static void SaveGoalsAndScore()
        {
            try
            {
                const string filePath = "goals.txt";

                if (File.Exists(filePath))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("goals.txt"))
                    {
                        foreach (var goal in goals)
                        {
                            file.Write($"{goal.GetType().Name},{goal.GoalDescription},{goal.Completed},{goal.RecordEvent()}");
                            if(goal is ChecklistGoal checklistGoal)
                            {
                                file.Write($", {checklistGoal.requiredEvents}, {checklistGoal.completedEvents}");
                            }

                            file.WriteLine();
                        }
                    }

                    Console.WriteLine("\nGoal and score saved successfully.");
                }
                else
                {
                    Console.WriteLine("The file 'goals.txt' does not exits.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while saving goals and score: {ex.Message}");
            }
        }
        private static void LoadGoalsAndScore()
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader("goals.txt"))
                {
                    goals.Clear();

                    while (!file.EndOfStream)
                    {
                        string[] goalData = file.ReadLine().Split(',');

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
                                    completedEvents = completedEvents
                                });
                                break;
                            default:
                                Console.WriteLine("Unknown goal type encountered during loading. Skipping...");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading goals and score: {ex.Message}");
            }
        }
    }
}