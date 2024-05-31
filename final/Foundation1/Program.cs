using System;

class Program
{
    public static void Main(string[] args)
    {
        // Create instances of videos
        Video video1 = new Video("Understanding Abstraction", "John Doe", 600);
        Video video2 = new Video("Encapsulation Explained", "Jane Smith", 750);
        Video video3 = new Video("Inheritance in C#", "Alice Johnson", 800);
        Video video4 = new Video("Polymorphism Overview", "Bob Brown", 900);

        // Add comments to each video
        video1.AddComment(new Comment("Mike", "Great explanation, thanks!"));
        video1.AddComment(new Comment("Sarah", "Very clear and concise."));
        video1.AddComment(new Comment("Dave", "Helped me understand abstraction much better."));

        video2.AddComment(new Comment("Anna", "Encapsulation is now my favorite topic."));
        video2.AddComment(new Comment("Tom", "Could you do a video on more advanced topics?"));
        video2.AddComment(new Comment("James", "Very informative, thank you."));

        video3.AddComment(new Comment("Emma", "I finally get inheritance!"));
        video3.AddComment(new Comment("Sophia", "This was really helpful."));
        video3.AddComment(new Comment("Liam", "Can you do more examples?"));

        video4.AddComment(new Comment("Olivia", "Polymorphism is a bit tricky but this helped."));
        video4.AddComment(new Comment("Noah", "Great video as always!"));
        video4.AddComment(new Comment("Mason", "More videos on this please!"));

        // Store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}