using System;
using System.Collections.Generic;
using System.Linq;

class MinersTask
{
    static void Main()
    {
        Dictionary<string, long> resourceAndQuanity = new Dictionary<string, long>();
        int count = 0;
        string resource = "";
        long quanity = 0;
        while (true)
        {
            
            string input = Console.ReadLine();
            count++;
            if (input=="stop")
            {
                foreach (var item in resourceAndQuanity)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
                break;
            }
            if (count % 2 != 0 && count != 0) 
            {
                resource = input;
            }
            else if (count % 2 == 0 && count != 0) 
            {
                quanity = long.Parse(input);
            }
            if (!resourceAndQuanity.ContainsKey(resource) && count % 2 == 0) 
            {
                resourceAndQuanity.Add(resource, quanity);
            }
            else if(resourceAndQuanity.ContainsKey(resource) && count % 2 == 0)
            {
                long tempSum = resourceAndQuanity[resource];
                resourceAndQuanity[resource] = tempSum + quanity;
            }         
        }
    }
}

