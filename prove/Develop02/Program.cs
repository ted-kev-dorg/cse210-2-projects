using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userChoice = -1;

        List<string> menu = new List<string>
        {
            "Please Select one of the following choices: ",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit ",
            "What is your choice? "
        };

        while (userChoice != 5)
        {
            
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
                
            }

            userChoice = int.Parse(Console.ReadLine());



            if (userChoice == 1)
            {
                journal.CreateJournalEntry(); 
            }

            else if (userChoice == 2)
            {
                journal.DisplayJournalEntries();
            }


            else if (userChoice == 3)
            {
                Console.WriteLine("Enter the file to open name: ");
                string filename = Console.ReadLine();
                

                journal.LoadFromCSV(filename);
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("Choose the file name: ");
                string filename = Console.ReadLine();
                
                journal.SaveToCSV(filename);
            }            

        }

    }
}