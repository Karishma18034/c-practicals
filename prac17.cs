using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter a real number
        Console.WriteLine("Enter a real number:");
        
        // Read input from the console
        double number = double.Parse(Console.ReadLine());
        
        // Compute the required values
        int smallAsInteger = (int)Math.Floor(number);   // Smallest integer less than or equal to the number
        int largeAsInteger = (int)Math.Ceiling(number); // Largest integer greater than or equal to the number
        
        // Print the results in one line
        Console.WriteLine("small as integer: {0}, large as integer: {1}, not less than, not greater than: {2}",smallAsInteger ,largeAsInteger,number);
    }
}
