using System;
public class SumDigit 
{ 
    public static void Main(string[] args) 
    { 
        Console.WriteLine("Enter a number:"); 
        int number = Convert.ToInt32(Console.ReadLine());    
        int sum = 0; 
        while (number != 0) 
        { 
            int remainder = number % 10; 
            sum += remainder; 
            number /= 10; 
        } 
        
        Console.WriteLine($"Sum of digits: {sum}"); 
    } 
}
