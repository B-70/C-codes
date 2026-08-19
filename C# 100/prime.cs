using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine ("Enter a number.");
        int n = int.Parse(Console.ReadLine());
        bool isprime = true ; 
        if (n<=1){
            isprime = false ; 
        }
        else
        {
            for(int i=2 ; i<=n/2;i++)
            {
                if (n%i==0)
                {
                    isprime = false ;
                    break;
                }
            }
        }
        if (isprime)
        {
            Console.WriteLine("prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}