using System;

class CitySearch
{
    static void Main(string[] args)
    {
        // Создаем массив строк с названиями городов
        string[] cities = new string[5] { "Москва", "Санкт-Петербург", "Нью-Йорк", "Лондон", "Париж" };

        Console.Write("Введите название города: "); // Приглашение пользователя ввести название города
        string cityName = Console.ReadLine(); // Считываем введенное пользователем название города

        int cityIndex = Array.IndexOf(cities, cityName); // Ищем индекс введенного города в массиве

        if (cityIndex != -1)
        {
            Console.WriteLine($"Город '{cityName}' найден в массиве. Индекс: {cityIndex}"); // Выводим сообщение, если город найден
        }
        else
        {
            Console.WriteLine($"Город '{cityName}' не найден в массиве."); // Выводим сообщение, если город не найден
        }
    }
}
