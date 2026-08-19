using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int digits = number.ToString().Length;
        int sum = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            sum += (int)Math.Pow(remainder, digits);
            number /= 10;
        }

        if (sum == originalNumber)
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        else
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
    }
}