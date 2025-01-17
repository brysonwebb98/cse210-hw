using System;

class Program
{


    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        Console.WriteLine($"Hello {userName}!");
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        Console.WriteLine($"{userName}, the number squared is {squaredNumber}!");

        
    }

}