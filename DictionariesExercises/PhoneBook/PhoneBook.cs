using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBook
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string cmd = input[0];
            

            if (cmd == "END" || cmd == "end")
            {
                break;
            }

            if (input.Count==3)
            {
                string contactNum = input[2];
                string contact = input[1];
                if (cmd == "A")
                {
                    if (!phoneBook.ContainsKey(contact))
                    {
                        phoneBook.Add(contact, contactNum);
                        
                    }
                    else if(phoneBook.ContainsKey(contact))
                    {
                        phoneBook[contact] = contactNum;
                    }

                }
            }
            else
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

