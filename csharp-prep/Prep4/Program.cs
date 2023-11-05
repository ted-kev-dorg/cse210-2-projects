using System;
using System.Net;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        
        int response= -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (response != 0)
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            if(response != 0)
            {
                numberList.Add(response);
            }           
        }
        
        int sum = 0;
        foreach (int item in numberList)
        {
            sum += item;
        }

        Console.WriteLine($"The sum is : {sum}");
        
        float average = ((float)sum) / numberList.Count;

        Console.WriteLine($"The average is: {average}");

        

        // Finding the largest number
        int largest = -1;
        foreach (int item in numberList)
        {
            if(item > largest)
            {
                largest = item;
            }
            
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}