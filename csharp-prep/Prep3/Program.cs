using System;

class Program
{
    static void Main(string[] args)
    { 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guessedNumber = 0;

        Console.Write("Guess a number between 1 and 100");

        while (guessedNumber != number)
        {
            guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < number)
            {
                Console.WriteLine("Higher! Guess again!");
            }

            else if (guessedNumber > number)
            {
                Console.WriteLine("Lower! Guess again!");
            }

            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }

        
        }

        
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}

