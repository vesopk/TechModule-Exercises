using System;


namespace GreaterOfTwo
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int result =GetMax(firstValue,secondValue);
                Console.WriteLine(result);
            }
            else if (type=="char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                char result = GetMax(firstValue,secondValue);
                Console.WriteLine(result);
            }
            else if (type=="string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
            
        }
        static int GetMax(int first,int second)
        {
            int result = Math.Max(first,second);
            return result;
        }
        static char GetMax(char first,char second)
        {
            
            int result =Math.Max(first,second);
            char intToChar = (char)result;
            return intToChar;
        }
        static string GetMax(string first,string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
