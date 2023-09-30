using System;

class CitySearch
{
    static void Main(string[] args)
    {
        string[] cities = new string[5] { "Москва", "Санкт-Петербург", "Нью-Йорк", "Лондон", "Париж" };

        Console.Write("Введите название города: ");
        string cityName = Console.ReadLine();

        int cityIndex = Array.IndexOf(cities, cityName);

        if (cityIndex != -1)
        {
            Console.WriteLine($"Город '{cityName}' найден в массиве. Индекс: {cityIndex}");
        }
        else
        {
            Console.WriteLine($"Город '{cityName}' не найден в массиве.");
        }
    }
}
