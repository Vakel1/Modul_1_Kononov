﻿using System;

class NumberGuessingGame
{
    static void Main(string[] args)
    {
        // Создаем объект Random для генерации случайного числа
        Random random = new Random();

        // Генерируем случайное число от 1 до 10
        int secretNumber = random.Next(1, 11);

        int attempts = 3; // Количество попыток

        Console.WriteLine("Угадайте число от 1 до 10.");

        while (attempts > 0)
        {
            Console.Write($"Осталось попыток: {attempts}. Введите вашу догадку: ");

            int guess;
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число.");
                    break; // Если число угадано, завершаем игру
                }
                else
                {
                    Console.WriteLine("Неверно. Попробуйте снова.");
                    attempts--; // Уменьшаем количество оставшихся попыток
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine($"Вы исчерпали все попытки. Загаданное число было {secretNumber}.");
        }
    }
}
