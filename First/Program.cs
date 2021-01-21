using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("3 или 4?");
        if (int.TryParse(Console.ReadLine(), out var number)) {
            if (number == 3) {
                Exercise3.Main();
            } else if (number == 4) {
                Exercise4.Main();
            }
        }
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
