 using System;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        // Code to determine the letter of the student's grade
        string letter = "";

        if(gradeNumber>=90)
        {
            letter = "A";
        }
        else if(gradeNumber>=80)
        {
            letter = "B";
        }
        else if(gradeNumber>=70)
        {
            letter = "C";
        }
        else if(gradeNumber>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Code to determine the sign of the student grade
        string sign = "";

        if (gradeNumber%10 >= 7)
        {
            sign ="+";
        }
        else if(gradeNumber%10 < 3)
        {
            sign = "-";

        }
        else
        {
            sign = "";

        }

        // Dertermine if to exclude "+" or "-" signs

        if(letter=="A" && sign=="+")
        {
            sign = "";
        }
        else if (letter=="F")
        {
            sign = "";
        }

        Console.WriteLine($"Your Grade is: {letter}{sign}");

        if(gradeNumber >= 70)
        {
            Console.WriteLine("Congratulation, You've passed the test");
        }
        else
        {
            Console.WriteLine("Sorry, you have to try again");
        }
        
    }
}