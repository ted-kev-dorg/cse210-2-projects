using System;

class Program
{
    static void Main(string[] args)
    {         
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");
        
        while (!scripture.IsCompletelyHidden())
        {                       
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());           
            scripture.HideRandomWord();            
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit and save your new achievement.");             

            string input = Console.ReadLine(); 
  
            if (input.ToLower() == "quit")
            {
                break;
                
            } 
        }           
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");                
        SaveScriptureToFile(reference);
        Console.WriteLine("New scripture learned has been successfully saved. KEEP LEARNING!!!");


    static void SaveScriptureToFile(Reference reference)
    {
        using (StreamWriter writer = new StreamWriter("scripture_learned.txt"))
        {
            writer.WriteLine(reference.GetDisplayText());
        }
    }
}
}
    
