using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);        
        
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("welcome to the program!");
        }

    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite Number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;

        }

    static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

    static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
}