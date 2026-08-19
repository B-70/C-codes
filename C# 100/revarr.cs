using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine("Descending numbers:");
        Console.WriteLine($"[{string.Join(",", numbers)}]");
    }
}
// int[] numbers = Console.ReadLine()
//                        .Split(' ')
//                        .Select(int.Parse)
//                        .OrderByDescending(x => x)
//                        .ToArray();

// Console.WriteLine($"[{string.Join(",", numbers)}]");