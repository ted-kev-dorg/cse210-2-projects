class Entry
{
    string mood, prompt, response, date;

    public Entry(string _mood, string _date, string _prompt, string _response)
    {
        mood = _mood;
        prompt = _prompt;
        response = _response;
        date = _date;
        
        
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {date} - Mood: {mood}");
        Console.WriteLine(prompt);
        Console.WriteLine(response); 
        Console.WriteLine();
        
    }

    public string getEntryAsCSV()
    {       
        
        return string.Format("{0} {1} {2} {3}", date, mood, prompt, response); 
    }


}