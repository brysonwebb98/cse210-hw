using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static string userChoice = "";
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
        Console.WriteLine("Select a choice from the menu: \n");
        
        userChoice = Console.ReadLine();

        Activity activity = null;
        
        if (userChoice == "1") 
        {
            activity = new Breathing();
        }
        else if (userChoice == "2")
        {
            activity = new Reflection();
        }
        else if (userChoice == "3")
        {
            activity = new Listing();
        }
        else if (userChoice == "4")
        {
            Console.Clear();
            Console.WriteLine("Thank you for coming! Come back anytime!");
            Console.ReadKey();
            return;
        }
        else
        {
            Console.WriteLine("You entered an invalid input. Please try again!");
        }

        if (activity != null)
        {
            activity.StartActivity();
        }
    }
}