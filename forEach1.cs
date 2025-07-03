using System;
class forEach1
{
    public static void Main()
    {
        int[] inventorySample = { 10, 20, 30, 40, 50 };
        int inventoryTotal = 0;
        foreach (int y in inventorySample)
        {
            inventoryTotal += y;
        }
        Console.WriteLine(inventoryTotal);
    }
}
