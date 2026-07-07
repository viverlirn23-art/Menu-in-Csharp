using System;

class Program
{
    static void Main()
    {
        int size = ReadSafeInt("How many numbers?");
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = ReadSafeInt($"Enter number {i + 1}:");
        }

        int choice;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 — Show array");
            Console.WriteLine("2 — Sum");
            Console.WriteLine("3 — Maximum");
            Console.WriteLine("4 — Minimum");
            Console.WriteLine("5 — Average");
            Console.WriteLine("6 — Check if number exists");
            Console.WriteLine("0 — Exit");

            choice = ReadSafeInt("Your choice:");

            switch (choice)
            {
                case 1:
                    foreach (int n in numbers) Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine("Sum: " + GetSum(numbers));
                    break;
                case 3:
                    Console.WriteLine("Max: " + GetMax(numbers));
                    break;
                case 4:
                    Console.WriteLine("Min: " + GetMin(numbers));
                    break;
                case 5:
                    Console.WriteLine("Average: " + GetAverage(numbers)); // Теперь работает красиво
                    break;
                case 6:
                    int value = ReadSafeInt("Enter number to check:");
                    Console.WriteLine("Contains: " + Contains(numbers, value));
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }

    static int ReadSafeInt(string message)
    {
        int result;
        Console.WriteLine(message);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Error! Please enter a valid integer.");
        }
        return result;
    }

    static int GetSum(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers) sum += n;
        return sum;
    }

    static int GetMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int n in numbers) if (n > max) max = n;
        return max;
    }

    static int GetMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (int n in numbers) if (n < min) min = n;
        return min;
    }

    static double GetAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return (double)GetSum(numbers) / numbers.Length; // Красивый переиспользуемый код!
    }

    static bool Contains(int[] numbers, int value)
    {
        foreach (int n in numbers) if (n == value) return true;
        return false;
    }
}
