using System;
public class sum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
    }
}