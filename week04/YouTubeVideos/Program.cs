using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Programming Tutorial", "John Doe", 300);
        Comment comment1a = new Comment("Alice", "Great tutorial!");
        Comment comment1b = new Comment("Bob", "Very informative, thanks!");
        Comment comment1c = new Comment("Charlie", "I learned a lot from this video.");
        Comment comment1d = new Comment("David", "Looking forward to more tutorials!");
        video1.AddComment(comment1a);
        video1.AddComment(comment1b);
        video1.AddComment(comment1c);
        video1.AddComment(comment1d);

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        Comment comment2a = new Comment("Eve", "This is exactly what I needed!");
        Comment comment2b = new Comment("Frank", "Excellent explanation of advanced topics.");
        Comment comment2c = new Comment("Grace", "I appreciate the depth of this tutorial.");
        Comment comment2d = new Comment("Hank", "Can't wait to apply these techniques in my projects.");
        video2.AddComment(comment2a);
        video2.AddComment(comment2b);
        video2.AddComment(comment2c);
        video2.AddComment(comment2d);

        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 600);
        Comment comment3a = new Comment("Ivy", "Design patterns are crucial for software design.");
        Comment comment3b = new Comment("Jack", "This video clarified a lot of concepts for me.");
        Comment comment3c = new Comment("Kathy", "Great examples of design patterns in C#.");
        Comment comment3d = new Comment("Leo", "I love how you explained each pattern with code examples.");
        video3.AddComment(comment3a);
        video3.AddComment(comment3b);
        video3.AddComment(comment3c);
        video3.AddComment(comment3d);

        Console.WriteLine("Video 1:");
        Console.WriteLine(video1.GetDisplayText());
        Console.WriteLine("\nVideo 2:");
        Console.WriteLine(video2.GetDisplayText());
        Console.WriteLine("\nVideo 3:");
        Console.WriteLine(video3.GetDisplayText());
    }
}