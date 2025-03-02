using System.Linq.Expressions;

public class Activity 
{
    protected string _startingMessage;
    protected string _activityDescription;
    protected int _activityDuration;
    protected string _endingMessage;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_startingMessage} Activity!");
        Console.WriteLine("");
        Console.WriteLine($"{_activityDescription}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        bool isValidInput = false;
        while (!isValidInput)
        {
            try
            {
                _activityDuration = int.Parse(Console.ReadLine());
                isValidInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number!");
            }
        }

        if (_startingMessage == "Breathing")
        {
            Breathing b = new Breathing();
            b.GuideBreathing(_activityDuration);
        }
        else if (_startingMessage == "Reflection")
        {
            Reflection r = new Reflection();
            r.GuideReflection(_activityDuration);
        }
        else if (_startingMessage == "Listing")
        {
            Listing l = new Listing();
            l.GuideListing(_activityDuration);
        }

        _endingMessage = GetEndingMessage(_activityDuration, _startingMessage); //this line is to get the ending message with the time and the activity!

        Console.Clear();
        Console.WriteLine($"{_endingMessage}");            
    }
    private string GetEndingMessage(int time, string activityName)
    {
        Console.Clear();
        return $"\nWell done!!\n\nYou have completed another {time} seconds of the {activityName} Activity!";
    }
    public void Loading(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("/");      
            Thread.Sleep(500);       
            Console.Write("\b");     
            Console.Write("-");      
            Thread.Sleep(500);       
            Console.Write("\b");     
            Console.Write("\\");     
            Thread.Sleep(500);       
            Console.Write("\b");     
            Console.Write("|");      
            Thread.Sleep(500);       
            Console.Write("\b");     
            Console.Write("-");      
            Thread.Sleep(500); 
            Console.Write("\b");
        }
    }
    
}

