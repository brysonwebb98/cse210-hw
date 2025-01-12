using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter;
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // FIRST PRINT STATEMENT
        Console.WriteLine("Your letter grade is: " + letter);
        string course;
        if (gradeInt>= 70)
        {
            course = "passed";
        }
        else
        {
            course = "failed";
        }
        Console.WriteLine($"You {course} this course!");
    }
}