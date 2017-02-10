using System;

class RandomizeWords
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');
        Random random = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            var currentWord = words[i];
            var randomIndex = random.Next(0,words.Length);
            var tempWord = words[randomIndex];
            words[i] = tempWord;
            words[randomIndex] = currentWord;
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

