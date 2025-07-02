using System;
class incrementAndDecrementOperator{
    public static void Main(){
        int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
    }
}
// First increment: 2
// Second increment: 3
// Third increment: 4
// First decrement: 3
// Second decrement: 2
// Third decrement: 1