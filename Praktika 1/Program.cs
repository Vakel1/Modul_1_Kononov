using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1. Перевести из Цельсия в Фаренгейты");
        Console.WriteLine("2. Перевести из Фаренгейтов в Цельсии");

        int option = int.Parse(Console.ReadLine());

        double temperature;

        switch (option)
        {
            case 1:
                Console.Write("Введите температуру в градусах Цельсия: ");
                temperature = double.Parse(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
                break;
            case 2:
                Console.Write("Введите температуру в градусах Фаренгейта: ");
                temperature = double.Parse(Console.ReadLine());
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine($"Температура в градусах Цельсия: {celsius}");
                break;
            default:
                Console.WriteLine("Некорректная опция.");
                break;
        }
    }

    // Метод для конвертации из Цельсия в Фаренгейты
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Метод для конвертации из Фаренгейтов в Цельсии
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
