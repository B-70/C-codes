using System;
using System.Collections.Generic;
public class program
{
    public static void Main()
    {
        int [] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Dictionary<int,int> freq = new Dictionary<int, int>();
        foreach(int num in numbers)
        {
            if(freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num]=1;
            }
        }
        foreach(var kvp in freq)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}