using System;
using System.Collections.Generic;

public static class MainClass
{
    public static void Main(string[] args)
    {
        List<int> original = new List<int>();
        Random random = new Random();

        FillListWithNumbers(original, random, 5);

        EnsureNumberRepeats(original, random, 2);
        EnsureNumberRepeats(original, random, 3);

        Console.WriteLine(string.Format("Original: {0}", string.Join(", ", original)));
    }

    private static void FillListWithNumbers(List<int> list, Random random, int count)
    {
        if (list.Count >= count)
        {
            return;
        }

        int newNumber = random.Next(1, 51);
        list.Add(newNumber);

        FillListWithNumbers(list, random, count);
    }

    private static void EnsureNumberRepeats(List<int> list, Random random, int repeatCount)
    {
        int repeats = random.Next(1, 51);

        while (list.Contains(repeats))
        {
            repeats = random.Next(1, 51);
        }

        for (int i=0; i < repeatCount; i++)
        {
            list.Add(repeats);
        }        
    }
}
