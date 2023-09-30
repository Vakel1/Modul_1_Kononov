using System;

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
            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Поздравляем! Вы угадали число.");
                break;
            }
            else
            {
                Console.WriteLine("Неверно. Попробуйте снова.");
                attempts--;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine($"Вы исчерпали все попытки. Загаданное число было {secretNumber}.");
        }
    }
}
