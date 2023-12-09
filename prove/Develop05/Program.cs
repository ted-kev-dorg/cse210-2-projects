using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        // for (int i = 5; i >0 ; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");            
        // }
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 

            i++;
            if (i>= animationStrings.Count)
            {
                i=0;
            }
        }


        Console.WriteLine("Done.");
    }



       
}