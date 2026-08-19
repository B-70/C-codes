using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to reverse:");
        int number = Convert.ToInt32(Console.ReadLine());
        string reversedStr = new string(number.ToString().Reverse().ToArray());
        int reversedNumber = int.Parse(reversedStr);
        Console.WriteLine($"Reversed Number: {reversedNumber}");    
    }
}
