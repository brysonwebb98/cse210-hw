using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2025;
        job1._endYear = 2030;
        

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2025;
        job2._endYear = 2030;
        
        
        // Resume section
        Resume myResume1 = new Resume();
        myResume1._name = "Bryson Webb";

        myResume1._jobs = new List<Job>();
        myResume1._jobs.Add(job1);
        myResume1._jobs.Add(job2);
        
        Console.WriteLine("");
        myResume1.DisplayResume();
        Console.WriteLine("");
        

    }
}