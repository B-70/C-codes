using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number.");
        int n = int.Parse(Console.ReadLine());
        for (int num = 2; num <= n; num++)
        {
            bool isprime = true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime)
            {
                Console.Write(num + " ");
            }
        }
    }
}