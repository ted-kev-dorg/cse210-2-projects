public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many response you can to the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("You May begin: ");
        GetListFromUser();
        DisplayEndingMessage();
    }

    

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine($"Start listing items related to {_name}...");
        List<string> itemList = new List<string>(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;

        while(DateTime.Now < endTime)
        {      
            Console.Write($"> ");
            itemList.Add(Console.ReadLine());
            i++;
        }
        
        Console.WriteLine($"You listed {i} items.");

        return itemList;
    }
}