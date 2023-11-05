using Mindfulness_Program;

bool quit = false;
Menu menu = new Menu();

do
{
    menu.DisplayMenu();
    #pragma warning disable CS8600
    Console.Write("> ");
    int choose = Convert.ToInt32(Console.ReadLine());
    #pragma warning restore CS8600

    if (choose == 1)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This Activity will help you " +
            "relax by walking your through breathing in and out slowly, Clear your mind and focus on your breathing");
        breathing.Run();
    }
    else if (choose == 2)
    {
        ReflectionActivity reflecting = new ReflectionActivity("Reflecting Activity", "This Activity will help you " +
            "reflect on times in your life when you have shown strength and resilience. This will help you recognize the " +
            "power you have and how you can use it in other aspects of yor life");
        reflecting.Run();
    }
    else if (choose == 3)
    {
        ListingActivity listing = new ListingActivity("Listing Activity", "This Activity will help you " +
            "reflect on the good things in your life by having you list as many things as you can in a certain area");
        listing.Run();
    }
    else if (choose == 4)
    {
        Console.WriteLine("Sure!, don´t forget do it later");
        Thread.Sleep(2000);
        quit = true;
    }
    else
    {
        Console.WriteLine($"{choose} - It is not an option");
        Thread.Sleep(2000);
    }
} while (quit == false);

