using System;

class EvenOddChecker
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine($"Число {number} четное.");
        }
        else
        {
            Console.WriteLine($"Число {number} нечетное.");
        }
    }

    // Метод для проверки четности числа
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
