using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBookUpgraded
{
    static void Main()
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
    
        while (true)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string cmd = input[0];
          
            if (cmd == "END" || cmd == "end")
            {
                break;
            }
            if (cmd == "ListAll")
            {
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                }
            }
          
            if (input.Count == 3)
            {
                string contactNum = input[2];
                string contact = input[1];
                if (cmd == "A")
                {
                    if (!phoneBook.ContainsKey(contact))
                    {
                        phoneBook.Add(contact, contactNum);
                    }
                    else if (phoneBook.ContainsKey(contact))
                    {
                        phoneBook[contact] = contactNum;
                    }
                }
               
            }
            else if (input.Count == 2) 
            {
                string contact = input[1];
                if (cmd == "S")
                {
                    if (phoneBook.ContainsKey(contact))
                    {
                        Console.WriteLine("{0} -> {1}", contact, phoneBook[contact]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                }
                
            }
            
        }
    }
}


