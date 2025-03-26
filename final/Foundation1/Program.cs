using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Everything To Know About Your Bali Trip", "Bryson Webb", 10);
        Comment comment1 = new Comment("Victoria H.", "That was incredible! I am ready to move there already!");
        Comment comment2 = new Comment("Johny Smith", "When can I apply?");
        Comment comment3 = new Comment("Sarah Marshall", "The Ubud part was my favorite!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("Daily Motivation", "David Goggins", 20);
        Comment v2comment1 = new Comment("Donald Webb", "Thank you for your content as it helps improve my life!");
        Comment v2comment2 = new Comment("Tamara Lyne", "Ready to kill the day!");
        Comment v2comment3 = new Comment("Tom Holdman", "Incredible!");
        video2.AddComment(v2comment1);
        video2.AddComment(v2comment2);
        video2.AddComment(v2comment3);
        videos.Add(video2);

        Video video3 = new Video("5-Minute Guided Meditation", "Calm & Relax", 5);
        Comment v3comment1 = new Comment("Olivia James", "Felt so relaxed after this. Thank you!");
        Comment v3comment2 = new Comment("Liam Roberts", "Just what I needed after a stressful day.");
        Comment v3comment3 = new Comment("Noah Lee", "Peaceful and soothing. Will do this daily.");
        video3.AddComment(v3comment1);
        video3.AddComment(v3comment2);
        video3.AddComment(v3comment3);
        videos.Add(video3);


        Video video4 = new Video("Skiing Adventure in Switzerland", "Travel Vlogs", 18);
        Comment v4comment1 = new Comment("Emily Clark", "The views are breathtaking!");
        Comment v4comment2 = new Comment("Daniel Smith", "Adding this to my bucket list!");
        Comment v4comment3 = new Comment("Sophia Reyes", "Such an epic adventure! Thanks for sharing.");
        video4.AddComment(v4comment1);
        video4.AddComment(v4comment2);
        video4.AddComment(v4comment3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            string videoSummary = video.GetSummary();
            Console.WriteLine($"\n{videoSummary}");
        }

        Console.WriteLine($"Thank you for reviewing {videos.Count()} videos, I hope that you have a wonderful day!");
    }
}