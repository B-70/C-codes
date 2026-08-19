using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number to reverse:");
        int number = Convert.ToInt32(Console.ReadLine());
        int reversedNumber = 0;
        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            number /= 10; 
        }
        Console.WriteLine($"Reversed Number: {reversedNumber}");
    }
}
