using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to reverse:");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberStr = number.ToString();
        string reversedStr = "";
        for (int i = numberStr.Length - 1; i >= 0; i--)
        {
            reversedStr += numberStr[i];
        }

        int reversedNumber = int.Parse(reversedStr);
        Console.WriteLine($"Reversed Number: {reversedNumber}");
        Console.WriteLine(numberStr.Length);
    }
}
