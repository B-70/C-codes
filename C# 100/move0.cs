using System;
public class Program
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = new int[numbers.Length];
        int index = 0;
// Put non-zero elements first
        for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != 0)
        {
        result[index] = numbers[i];
        index++;
        }
    }
Console.WriteLine(string.Join(" ", result));
    }
}