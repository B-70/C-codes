using System;
public class Program
{
    public static void Main()
    {
int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//.Distinct().ToArray(); //this will remove duplicates

for (int i = 0; i < numbers.Length; i++)
{
    bool duplicate = false;

    for (int j = 0; j < i; j++)
    {
        if (numbers[i] == numbers[j])
        {
            duplicate = true;
            break;
        }
    }

    if (!duplicate)
    {
        Console.Write(numbers[i] + " ");
    }
}
    }
}
//another way to do this is by using HashSet
//using System;
//using System.Collections.Generic;
//public class Program
//{
//    public static void Main()
//    {
//        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        HashSet<int> uniqueNumbers = new HashSet<int>();  
//        foreach (int number in numbers)
//        { 
//            uniqueNumbers.Add(number);
//        }
//        Console.WriteLine(string.Join(" ", uniqueNumbers));    
//    }
//}