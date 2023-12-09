using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for this section? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready to begin in 3 seconds...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You've completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];       
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b"); 

            i++;

            if (i>=animationStrings.Count)
            {
                i = 0;
            }           
        }
        
    }

    
    public void ShowCountDown()
    {
       
        for (int i = 3; i >0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}
