using System;
class ifElseStatements
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
            Console.WriteLine("Congratulation you get the bonus of 6 Points.");
            totalOutcome += 6;
        }
        else if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("Congratulation you get the bonus of 2 Points.");
            totalOutcome += 2;
        }
        if (totalOutcome >= 15)
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Congratulation, you WIN!!");
        }
        else
        {
            Console.WriteLine(roll1 + " + " + roll2 + " + " + roll3 + " = " + totalOutcome);
            Console.WriteLine("Sorry, you LOSE!!");
        }
    }
}