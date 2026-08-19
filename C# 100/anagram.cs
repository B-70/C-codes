using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter another string:");
        string input2 = Console.ReadLine();
        if(input1.Length != input2.Length)
        {
            Console.WriteLine("The strings are not anagrams.");
            return;
        }
        char[] charArray1 = input1.ToLower().ToCharArray();
        char[] charArray2 = input2.ToLower().ToCharArray();
        Array.Sort(charArray1);
        Array.Sort(charArray2);
        if (new string(charArray1) == new string(charArray2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }
        
}