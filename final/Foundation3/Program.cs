using System;

class Program
{
    static void Main(string[] args)
    {
        // LECTURE EVENT
        Address addressLecture = new Address("101 University Ave", "Cambridge", "MA", "USA", "02139");
        Lecture lecture = new Lecture("Introduction to Coding: Best Practices for Beginners", "A lecture focused on teaching coding fundamentals, debugging techniques, and best practices in software development. Ideal for students new to programming.", "4/15/2025", "10:00 AM", addressLecture, "Bryson Webb", 10000);
        Console.WriteLine($"\nStandard Details:\n{lecture.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details:\n{lecture.GetLectureFull()}");
        Console.WriteLine($"\nShort Description:\n{lecture.GetShortLectureDescription()}");
        
        // RECEPTION EVENT
        Address addressReception = new Address("5000 Park Blvd", "Dallas", "TX", "USA", "75204");
        Reception reception = new Reception("Cinderella's Grand Ball", "Join us for the magical evening of the year at Cinderella's Grand Ball! Enjoy dancing, royal music, and a night of enchantment. RSVP to attend this elegant event.", "12/15/2025", "7:00 PM", addressReception, "RSVP@FairyTaleCastle.com");
        Console.WriteLine($"\nStandard Details:\n{reception.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details:\n{reception.GetReceptionFull()}");
        Console.WriteLine($"\nShort Description:\n{reception.GetShortReceptionDescription()}");

        // OUTDOOR EVENT
        Address addressOutdoor = new Address("789 Oak Tree Rd", "Lakewood", "CO", "USA", "80401");
        Outdoor outdoor = new Outdoor("Grand Canyon Hiking Adventure", "Join us for an exciting hiking adventure in the Grand Canyon! Experience breathtaking views, explore nature, and enjoy a day in one of the world's most beautiful landscapes. Don't forget to bring your camera!", "6/25/2025", "8:00 AM", addressOutdoor, "Sunny with clear skies, temperature around 75°F");
        Console.WriteLine($"\nStandard Details:\n{outdoor.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details:\n{outdoor.GetOutdoorFull()}");
        Console.WriteLine($"\nShort Description:\n{outdoor.GetShortOutdoorDescription()}");
        

    }
}