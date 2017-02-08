using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main()
    {
        var words = Console.ReadLine().ToLower().Split(' ');
        var wordsCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!wordsCount.ContainsKey(word))
            {
                wordsCount[word] = 0;
            }
            wordsCount[word]++;
        }

        var result = new List<string>();

        foreach (var item in wordsCount)
        {
            if (item.Value % 2 !=0)
            {
                result.Add(item.Key);
            }
        }
        Console.WriteLine(String.Join(", ",result));
    }
}

