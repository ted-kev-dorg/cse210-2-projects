public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public  void Run()
    {
        DisplayStartingMessage();  

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
           Console.Write("Breathe in ...");
           ShowCountDown();
           Console.WriteLine();
           Console.Write("Now breathe out...");
           ShowCountDown();
           Console.WriteLine();
           Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}