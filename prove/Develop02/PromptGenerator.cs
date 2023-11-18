using System.Collections.Generic;

class PromptGenerator
{
    List<string> prompts;    
    
    public PromptGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {    
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "What did understand from your scripture study today? ",
            "How did you use your break time at work? ",
            "What do you have to improve to have a more productive day tomorrow? ",
            "What goals do you have for the future, and how can you start working towards them? ",
            "What challenges did I face today, and how did I overcome them? "

        };
        
        Random random = new Random();             
        int index = random.Next(prompts.Count);
        string randomPrompt = prompts[index];
        return randomPrompt;
    }
}