using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Fibonacci terms to generate:");
        int count = Convert.ToInt32(Console.ReadLine());

        // Display the Fibonacci series
        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.ReadKey();
    }

    // Recursive function to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
