using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video
        {
            Title = "C# Basics",
            Author = "CodingExpert",
            LengthInSeconds = 300
        };

        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Very helpful content.");
        video1.AddComment("User3", "I have a question.");

        Video video2 = new Video
        {
            Title = "Object-Oriented Programming",
            Author = "CodeMaster",
            LengthInSeconds = 450
        };

        video2.AddComment("User4", "Awesome explanation!");
        video2.AddComment("User5", "Clear and concise.");
        video2.AddComment("User6", "Looking forward to more tutorials.");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);

        // Display information for each video
        foreach (var video in videos)
        {

        }
    }
}