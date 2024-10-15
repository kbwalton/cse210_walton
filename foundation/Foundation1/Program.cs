using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

       Video video1 = new Video("The Basics","Kaliah Walton",300 );
       video1.AddComment(new Comment("Alex", "Awesome Video!"));
       video1.AddComment(new Comment("Ben", "Great job!"));
       video1.AddComment(new Comment("Brett", "Thank you for posting!"));
       videos.Add(video1);

       Video video2 = new Video("The Importance of Abstraction","Heather Jacobson", 450);
       video2.AddComment(new Comment("Keith", "It makes so much sense now."));
       video2.AddComment(new Comment("Seth", "Thank you for clarifying"));
       videos.Add(video2);

       Video video3 = new Video("The Importance of Encapsulation","Jeff Warbler", 500);
       video3.AddComment(new Comment("Shrek", "I love this video."));
       video3.AddComment(new Comment("Lorax", "Why would I need to know this?"));
       video3.AddComment(new Comment("Kurt", "How often am I going to use Encapsulation in the real world"));
       videos.Add(video3);

       foreach (var video in videos)
       {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            Console.WriteLine(video.GetComments());
            Console.WriteLine("---------------------------");
        }  
       
    }
}