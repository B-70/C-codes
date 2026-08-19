using System;
public class Program 
{ 
    public static void Main() 
    { 
        Console.WriteLine("Enter a number:"); 
        int number = Convert.ToInt32(Console.ReadLine()); 
        if (number == 0)
        {
            Console.WriteLine("Total digits: 1");
            return;
        }
        int count = 0; 
        int temp = Math.Abs(number); 

        while (temp > 0)
        {
            temp /= 10; 
            count++;    
        }
        Console.WriteLine("Total digits: " + count);
    } 
}
