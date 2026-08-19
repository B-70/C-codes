using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(numbers);
        Console.WriteLine("Sorted numbers:");
        Console.WriteLine($"[{string.Join(",", numbers)}]");
        Console.WriteLine($"Second largest: {numbers[^2]}");
    }
}