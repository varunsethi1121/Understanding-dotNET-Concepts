using System;
class forEach2
{
    public static void Main()
    {
        int[] inventorySample = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int binItemCount = 0;
        int inventoryTotal = 0;
        foreach (int y in inventorySample)
        {
            inventoryTotal += y;
            binItemCount++;
            Console.WriteLine("Current bin item count is: " + binItemCount + " with current item at: " + y + " making inventory total to be: " + inventoryTotal);
        }
    }
}

// Current bin item count is: 1 with current item at: 10 making inventory total to be: 10
// Current bin item count is: 2 with current item at: 20 making inventory total to be: 30
// Current bin item count is: 3 with current item at: 30 making inventory total to be: 60
// Current bin item count is: 4 with current item at: 40 making inventory total to be: 100
// Current bin item count is: 5 with current item at: 50 making inventory total to be: 150
// Current bin item count is: 6 with current item at: 60 making inventory total to be: 210
// Current bin item count is: 7 with current item at: 70 making inventory total to be: 280
// Current bin item count is: 8 with current item at: 80 making inventory total to be: 360
// Current bin item count is: 9 with current item at: 90 making inventory total to be: 450
// Current bin item count is: 10 with current item at: 100 making inventory total to be: 550
