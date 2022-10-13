// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число, посчитаем сумму содержащихся в нём цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumdigits = default;
int size = default;
int i = 1;
int divide = 1;
int lastDigit=0;
while (number > 0)
{
    lastDigit = number%10;
    sumdigits+=lastDigit;
    i++;
    number=number/10;
}
Console.WriteLine($"Результат: {sumdigits} ");


