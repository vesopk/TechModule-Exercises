using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(new char[] {',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' },
            StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> upperCase = new List<string>();
        List<string> lowerCase = new List<string>();
        List<string> mixedCase = new List<string>();

        foreach (string word in words)
        {
            bool isAllUpper = true;
            bool isAllLower = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    isAllUpper = false;
                }
                else if (Char.IsUpper(word[i]))
                {
                    isAllLower = false;
                }
                else
                {
                    isAllLower = false;
                    isAllUpper = false;
                }
                
            }
            if (isAllLower)
            {
                lowerCase.Add(word);
            }
            else if (isAllUpper)
            {
                upperCase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }

        }


        Console.WriteLine("Lower-case: {0}",string.Join(", ",lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ",mixedCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ",upperCase));
    }
}

