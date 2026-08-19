using System;
public class posneg
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine($"{num} is a positive number.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is a negative number.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}