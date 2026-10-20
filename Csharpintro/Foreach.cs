
using System;

class Foreach
{
    static void fe(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
