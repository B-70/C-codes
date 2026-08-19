using System;
public class fibonacci
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
            {
                c = i;
            }
            else
            {
                a = b;
                b = a+b;
            }
            Console.WriteLine(c);
        }
    }
}