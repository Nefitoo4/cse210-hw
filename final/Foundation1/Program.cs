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
            List<Video> videos = new List<Video>();

            // Create videos and add comments
            Video video1 = new Video
            {
                Title = "How to make Git configurations",
                Author = "CodingExpert",
                LengthInSeconds = 300
            };

            video1.AddComment("User1", "Great video!");
            video1.AddComment("User2", "Very helpful content.");
            video1.AddComment("User3", "I have a question.");

            Video video2 = new Video
            {
                Title = "All about .NET Framework",
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
                video.DisplayVideoInfo();
            }
        }
    }
}