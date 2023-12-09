public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            
        };
    }

    public  void Run()
    {
        // DisplayStartingMessage();
        // foreach (var prompt in _prompts)
        // {
        //     DisplayPrompt(prompt);
        //     foreach (var question in _questions)
        //     {
        //         DisplayQuestion(question);
        //     }
        // }
        // DisplayEndingMessage();

        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each ofthe following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            
            DisplayQuestion();           
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        // Console.WriteLine(prompt);
        ShowCountDown();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(10);
    }
}