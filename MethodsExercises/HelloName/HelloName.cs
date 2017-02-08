using System;

class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(PrintHelloName(name));

    }

    static string PrintHelloName(string name)
    {
        string message = ($"Hello, {name}!");
        return message;
    }

}


