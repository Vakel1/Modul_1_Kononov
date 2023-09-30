using System;

class EvenOddChecker
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: "); // Приглашение пользователя ввести число
        int number = int.Parse(Console.ReadLine()); // Считываем введенное пользователем число и преобразуем его в int

        if (IsEven(number))
        {
            Console.WriteLine($"Число {number} четное."); // Выводим сообщение о четности числа, если условие выполняется
        }
        else
        {
            Console.WriteLine($"Число {number} нечетное."); // Выводим сообщение о нечетности числа, если условие не выполняется
        }
    }

    // Метод для проверки четности числа
    static bool IsEven(int number)
    {
        return number % 2 == 0; // Возвращаем true, если число четное, и false, если число нечетное
    }
}
