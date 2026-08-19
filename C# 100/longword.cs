using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string [] words = input.Split(' ');
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("Longest word: " + longestWord);
    }
}