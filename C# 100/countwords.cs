using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string[] words1=input.Split(' ');
        Console.WriteLine("Total words: " + words.Length);
        Console.WriteLine("Total words (alternative method): " + words1.Length);
    }
}