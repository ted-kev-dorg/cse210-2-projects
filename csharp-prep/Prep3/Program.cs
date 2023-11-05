using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomMagicNumber = new Random();
        int magicNumber = randomMagicNumber.Next(1,100);

        int guessNumber = -1;
        int count = 0;
        
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            count++;
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Your guessed it!");
            }
        
        } 
        Console.WriteLine($"You made {count} try to have it right");
        Console.WriteLine("Congratulations");
        
    }
}