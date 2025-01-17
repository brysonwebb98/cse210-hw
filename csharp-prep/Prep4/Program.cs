using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numberList = new List<int>();
        int sum = 0;
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());

            if (number !=0)
            {
                numberList.Add(number);
                sum += number;
            }
        }
        
        Console.WriteLine("You entered these numbers:");
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"Total sum of all numbers was {sum}");
        Console.WriteLine($"Average is: {sum / numberList.Count}");
        Console.WriteLine($"The largest number is {numberList.Max()}!");

    }
}