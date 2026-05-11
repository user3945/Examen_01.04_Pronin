using System;

class EvenOdd
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите целое число: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int number))
        {
            string result = (number % 2 == 0) ? "Чётное" : "Нечётное";
            Console.WriteLine($"{number} — {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число.");
        }
    }
}