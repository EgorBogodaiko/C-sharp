// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все натуральные числа в промежутке от {number} до 1: ");
realNumbers(number);

void realNumbers(int num)
{
    if (num == 0) return;
    if (num == 1)
    {
        System.Console.Write($"{num}");
        realNumbers(num - 1);
    }
    else
    {
        System.Console.Write($"{num}, ");
        realNumbers(num - 1);
    }
    return;
}
