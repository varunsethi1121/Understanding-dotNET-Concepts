using System;
class methodOverloading
{
    public static void Main(String[] args)
    {
        Random dice = new Random();
        int outcome1 = dice.Next(1, 101);
        int outcome2 = dice.Next(101, 201);
        Console.WriteLine("First Outcome: " + outcome1);
        Console.WriteLine("Second Outcome: " + outcome2);
    }
}
