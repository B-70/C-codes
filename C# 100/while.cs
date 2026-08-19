using System;
public class whileloop
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}