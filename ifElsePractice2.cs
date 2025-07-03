using System;
class ifElsePractice2
{
    public static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
        {
            Console.WriteLine("Days left for your subscription of Expire is/are: " + daysUntilExpiration);
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
        {
            Console.WriteLine("Days left for your subscription of Expire is/are: " + daysUntilExpiration);
            Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.");
            Console.WriteLine("Renew now and save 10%");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Days left for your subscription of Expire is/are: " + daysUntilExpiration);
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine("Renew now and save 20%");
        }
        else if (daysUntilExpiration < 1)
        {
            Console.WriteLine("Days left for your subscription of Expire is/are: " + daysUntilExpiration);
            Console.WriteLine("Your subscription has expired.");
        }
        else
        {
            Console.WriteLine("Days left for your subscription of Expire is/are: " + daysUntilExpiration);
            Console.WriteLine("");
        }
    }
}