using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("what is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}