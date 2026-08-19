using System;
using System.Collections.Generic;
using System.Linq;
public class large
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        if (x > y && x > z)
        {
            Console.WriteLine($"x is the largest number: {x}");
        }
        else if (y > x && y > z)
        {
            Console.WriteLine($"y is the largest number: {y}");
        }
        else
        {
            Console.WriteLine($"z is the largest number: {z}");
        }
    }
}