using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: "); // Приглашение пользователя ввести строку
        string input = Console.ReadLine(); // Считываем введенную пользователем строку

        if (IsPalindrome(input))
        {
            Console.WriteLine("Это палиндром."); // Выводим сообщение, если строка является палиндромом
        }
        else
        {
            Console.WriteLine("Это не палиндром."); // Выводим сообщение, если строка не является палиндромом
        }
    }

    // Метод для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        // Удаляем все пробелы и приводим строку к нижнему регистру
        str = str.Replace(" ", "").ToLower();

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; // Если символы не совпадают, строка не является палиндромом
            }
            left++;
            right--;
        }

        return true; // Если все символы совпадают, строка является палиндромом
    }
}
