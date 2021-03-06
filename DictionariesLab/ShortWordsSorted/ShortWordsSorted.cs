﻿using System;
using System.Collections.Generic;
using System.Linq;
class ShortWordsSorted
{
    static void Main()
    {
        var words = Console.ReadLine().ToLower().Split(new[] { ".", ",", ":", ";", "(", ")", "[", "]", "\"", "'", "\\", "/", "!", "?", " " },
            StringSplitOptions.RemoveEmptyEntries).ToList();
        var result = words.Where(w => w.Length < 5).Distinct().OrderBy(w => w);
        Console.WriteLine(string.Join(", ",result));
    }
}

