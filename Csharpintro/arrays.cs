using System;
        internal class Arrays
        {
            static void arrays(string[] args)
            {
                // Declare and initialize an array
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Display array elements
                Console.WriteLine("Array Elements:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
}
