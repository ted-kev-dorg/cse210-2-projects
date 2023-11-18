using System;
using System.Collections.Generic;
using System.IO;

class Journal
{ 
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

     public void CreateJournalEntry()
    {
        Console.WriteLine("What is you mood now? ");
        string mood = Console.ReadLine();

        PromptGenerator promptGen = new PromptGenerator();
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("=>");
        string response = Console.ReadLine();

        string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

        Entry entry = new Entry(mood ,date, prompt, response);
        entries.Add(entry);
    

    }

     public void SaveToCSV(string filename)
    {
       
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.getEntryAsCSV());
            }
        }

    }

     public void LoadFromCSV(string filename)
    {
        
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
    }

}