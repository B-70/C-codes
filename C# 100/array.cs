using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number with spaces:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Number at index {i}: {numbers[i]}");
        }
    }
}