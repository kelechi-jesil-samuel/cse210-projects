using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Learn C# in 1 Hour", "John Doe", 3600);
        video1.AddComment(new Comment("Alice", "Great tutorial, very helpful!"));
        video1.AddComment(new Comment("Bob", "Thanks for explaining classes so clearly."));
        video1.AddComment(new Comment("Charlie", "I finally understand abstraction."));

        Video video2 = new Video("My Trip to Japan", "Jane Smith", 845);
        video2.AddComment(new Comment("David", "Wow, amazing footage!"));
        video2.AddComment(new Comment("Eva", "Where did you stay in Tokyo?"));
        video2.AddComment(new Comment("Frank", "Adding this to my bucket list."));
        video2.AddComment(new Comment("Grace", "The food looks incredible."));

        Video video3 = new Video("Top 10 Programming Tips", "CodeMaster", 1200);
        video3.AddComment(new Comment("Henry", "Tip #4 changed my life."));
        video3.AddComment(new Comment("Ivy", "Please make a part 2!"));
        video3.AddComment(new Comment("Jack", "Solid advice."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
            Console.WriteLine("--------------------------\n");
        }
    }
}