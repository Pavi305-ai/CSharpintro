using System;

class Operators
{
    static void operators(string[] args)
    {
        int a = 10;
        int b = 5;

        // Arithmetic Operators
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("Equal: " + (a == b));
        Console.WriteLine("Greater: " + (a > b));
        Console.WriteLine("Less: " + (a < b));

        // Logical Operators
        Console.WriteLine("AND: " + (a > 5 && b < 10));
        Console.WriteLine("OR: " + (a < 5 || b < 10));
        Console.WriteLine("NOT: " + !(a > b));

        // Assignment Operator
        a += 2;
        Console.WriteLine("Assignment (a += 2): " + a);
    }
}