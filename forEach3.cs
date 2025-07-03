using System;
class forEach3
{
    public static void Main()
    {
        string[] fradulantOrderSample = {"B123" , "C234" , "A345" , "C15" , "B177" , "G3003" , "C235" , "B179"};
        foreach(string order in fradulantOrderSample){
            if (order.StartsWith("B"))
            {
                Console.WriteLine(order);
            }
        }
    }
}
