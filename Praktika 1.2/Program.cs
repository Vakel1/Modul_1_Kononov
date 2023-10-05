using System;

class EvenOddChecker
{
    static void Main(string[] args)
    {
        int number;
        if (TryGetNumberFromUser(out number))
        {
            if (IsEven(number))
            {
                Console.WriteLine($"Число {number} четное.");
            }
            else
            {
                Console.WriteLine($"Число {number} нечетное.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
        }
    }
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool TryGetNumberFromUser(out int result)
    {
        Console.Write("Введите целое число: ");
        return int.TryParse(Console.ReadLine(), out result);
    }

}
