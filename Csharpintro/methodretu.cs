
using System;

class Method
{
    // Void return type
    static void Display()
    {
        Console.WriteLine("Hello C#");
    }

    // Int return type
    static int GetNumber()
    {
        return 100;
    }

    // String return type
    static string GetName()
    {
        return "Pavithra";
    }

    // Double return type
    static double GetPrice()
    {
        return 99.50;
    }

    // Bool return type
    static bool IsPassed()
    {
        return true;
    }

    // Char return type
    static char GetGrade()
    {
        return 'A';
    }

    static void m(string[] args)
    {
        Display();

        int number = GetNumber();
        Console.WriteLine("Number: " + number);

        string name = GetName();
        Console.WriteLine("Name: " + name);

        double price = GetPrice();
        Console.WriteLine("Price: " + price);

        bool result = IsPassed();
        Console.WriteLine("Passed: " + result);

        char grade = GetGrade();
        Console.WriteLine("Grade: " + grade);
    }
}
