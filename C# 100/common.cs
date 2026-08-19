using System;
public class Program
{
    public static void Main()
    {
int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < A.Length; i++)
{
    for (int j = 0; j < B.Length; j++)
    {
        if (A[i] == B[j])
        {
            Console.Write(A[i] + " ");
            break;
        }
    }
}

    }
}
