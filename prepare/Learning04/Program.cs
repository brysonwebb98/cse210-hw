using System;

class Program
{
    
    static void Main(string[] args)
    {
        // ASSIGNMENTS CLASS 
        Console.WriteLine("");
        Assignment student1 = new Assignment("Bryson", "Math");
        Console.WriteLine(student1.GetSummary());

        // MATHASSIGNMENT CLASS
        Console.WriteLine("");
        MathAssignment student2 = new MathAssignment("Victoria", "History", "Section 7.3", "Problems 10-20");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        // WRITING ASSIGNMENT CLASS
        Console.WriteLine("");
        WritingAssignment student3 = new WritingAssignment("Tommy Smith", "Science", "How to Develop An Atom");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}