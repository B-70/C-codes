using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Maximum: {max}");
        
    }
}