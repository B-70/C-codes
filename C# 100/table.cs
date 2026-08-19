using System;
public class table
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}