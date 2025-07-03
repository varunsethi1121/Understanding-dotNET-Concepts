
using System;
class ifElsePractice
{
    public static void Main()
    {
        Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);
        int totalOutcome = roll1 + roll2 + roll3;

        if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("Congratulation you get the bonus of 2 Points.");
                totalOutcome += 6;
            }
            else
            {
                Console.WriteLine("Congratulation you get the bonus of 6 Points.");
                totalOutcome += 2;
            }
        }
        // If the player scores greater or equal to 16, they'll Won a new car.
        // If the player scores greater or equal to 10, they'll Won a new laptop.
        // If the player scores exactly 7, they'll Won a trip.
        // Otherwise, the player Wons a kitten.
        if (totalOutcome >= 16)
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Congratulation, you Won a Car!!");
        }
        else if (totalOutcome >= 10)
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Congratulation, you Won a Laptop!!");
        }
        else if (totalOutcome == 7)
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Congratulation, you Won a Trip");
        }
        else
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Congratulation, you Won a Kitten");
        }
    }
}