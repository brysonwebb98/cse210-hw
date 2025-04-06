using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("07 April, 2025", 30, 4.8); 
        Cycling bike = new Cycling("07 April, 2025", 45, 20.0); 
        Swimming swim = new Swimming("07 April, 2025", 30, 20); 

        var activities = new List<Activity>();
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"\n{activity.GetSummary()}");
            Console.WriteLine();
        }
    }
}