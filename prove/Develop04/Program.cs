using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            Activity selectedActivity;

            switch (choice)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectingActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    continue;
            }

            // Call the Run method on the specific derived class
            if (selectedActivity is BreathingActivity breathingActivity)
            {
                breathingActivity.Run();
            }
            else if (selectedActivity is ReflectingActivity reflectingActivity)
            {
                reflectingActivity.Run();
            }
            else if (selectedActivity is ListingActivity listingActivity)
            {
                listingActivity.Run();
            }
        }
    }
}