using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Сколько чисел?");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Введите число:");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int choice;

        do
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать массив");
            Console.WriteLine("2 — Сумма");
            Console.WriteLine("3 — Максимум");
            Console.WriteLine("4 — Минимум");
            Console.WriteLine("5 — Среднее");
            Console.WriteLine("6 — Проверить число");
            Console.WriteLine("0 — Выход");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    foreach (int n in numbers)
                    {
                        Console.WriteLine(n);
                    }
                    break;

                case 2:
                    Console.WriteLine("Сумма: " + GetSum(numbers));
                    break;

                case 3:
                    Console.WriteLine("Макс: " + GetMax(numbers));
                    break;

                case 4:
                    Console.WriteLine("Мин: " + GetMin(numbers));
                    break;

                case 5:
                    Console.WriteLine("Среднее: " + GetAverage(numbers));
                    break;

                case 6:
                    int value;
                    bool isNumber;

                    do
                    {
                        Console.Write("Введите число: ");
                        isNumber = int.TryParse(Console.ReadLine(), out value);

                        if (!isNumber)
                        {
                            Console.WriteLine("Ошибка! Попробуйте снова.");
                        }

                    } while (!isNumber);

                    bool result = Contains(numbers, value);
                    Console.WriteLine("Есть ли число: " + result);
                    break;

                case 0:
                    Console.WriteLine("Выход...");
                    break;

                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

        } while (choice != 0);
    }

    static int GetSum(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static int GetMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        return max;
    }

    static int GetMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (int n in numbers)
        {
            if (n < min)
            {
                min = n;
            }
        }
        return min;
    }

    static double GetAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        return (double)sum / numbers.Length;
    }

    static bool Contains(int[] numbers, int value)
    {
        foreach (int n in numbers)
        {
            if (n == value)
            {
                return true;
            }
        }
        return false;
    }
}