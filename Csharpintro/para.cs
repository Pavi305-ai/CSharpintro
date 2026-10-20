
using System;

class Para
{
    // int parameter and int return type
    static int Add(int a, int b)
    {
        return a + b;
    }

    // string parameter and string return type
    static string GetMessage(string name)
    {
        return "Hello " + name;
    }

    // double parameter and double return type
    static double CalculatePrice(double price, double tax)
    {
        return price + tax;
    }

    // int parameter and bool return type
    static bool IsEligible(int age)
    {
        return age >= 18;
    }

    // char parameter and char return type
    static char GetGrade(char grade)
    {
        return grade;
    }

    static void Main(string[] args)
    {
        int sum = Add(10, 20);
        Console.WriteLine("Sum: " + sum);

        string message = GetMessage("Pavithra");
        Console.WriteLine(message);

        double total = CalculatePrice(100, 18);
        Console.WriteLine("Total Price: " + total);

        bool eligible = IsEligible(22);
        Console.WriteLine("Eligible: " + eligible);

        char result = GetGrade('A');
        Console.WriteLine("Grade: " + result);
    }
}
