using System;
class stringManipulation{
    public static void Main(){
        int unitSold = 9;
        string unitSoldBy = "abc";
        Console.WriteLine(unitSoldBy + " sold " + unitSold + " units.");
        Console.WriteLine(unitSoldBy + " sold " + unitSold + 9 + " units.");
        Console.WriteLine(unitSoldBy + " sold " + (unitSold + 9) + " units.");
    }
}
// abc sold 9 units.
// abc sold 99 units.
// abc sold 18 units.