using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos and comments
            Video video1 = new Video("Introduction to C#", "CodingGuru", 300);
            video1.AddComment(new Comment("User1", "Great video!"));
            video1.AddComment(new Comment("User2", "Very helpful."));
            video1.AddComment(new Comment("User3", "I learned a lot."));

            Video video2 = new Video("Python Basics Tutorial", "PythonMaster", 240);
            video2.AddComment(new Comment("User1", "Nice explanation."));
            video2.AddComment(new Comment("User4", "Could you cover advanced topics too?"));

            Video video3 = new Video("JavaScript Fundamentals", "JSExpert", 400);
            video3.AddComment(new Comment("User2", "Awesome content."));
            video3.AddComment(new Comment("User5", "I have a question about closures."));

            // Put each video in the list
            List<Video> videos = new List<Video>
            {
                video1,
                video2,
                video3
            };

            // Iterate through the list and display video details and comments
            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.ToString()}");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine(comment.ToString());
                }

                Console.WriteLine(); // Add a newline for better readability
                Console.WriteLine("Press enter to see the outputs");
                Console.ReadLine(); // Wait for user input before closing
            }
        }
    }
}