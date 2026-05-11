using System;

class VowelCounter
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите строку: ");
        string input = Console.ReadLine() ?? "";

        string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

        int count = 0;
        foreach (char c in input)
        {
            if (vowels.Contains(c))
                count++;
        }

        Console.WriteLine($"\nСтрока: \"{input}\"");
        Console.WriteLine($"Количество гласных букв: {count}");
    }
}
