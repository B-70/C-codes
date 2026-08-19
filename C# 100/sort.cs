using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] numbers = { 40, 10, 30, 20, 50 };
        for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] > numbers[j + 1])//for descening order, change > to <
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}
Console.WriteLine($"[{string.Join(",", numbers)}]");
    }
}