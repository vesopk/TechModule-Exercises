﻿using System;
using System.Collections.Generic;

    class EmailFix
{
        static void Main()
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string ending = email.Substring(email.Length - 2, 2).ToLower();
                if (ending != "uk" && ending != "us")
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var pair in emails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }