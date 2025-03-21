using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your Last name? ");
        string Last = Console.ReadLine();

        Console.WriteLine($"Your name is {Last}, {first} {Last}");
    }
}