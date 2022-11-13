// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

 if (number1 > number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
    
Console.WriteLine($"Сумма натуральных чисел от {number1} до {number2} = {SumBetween(number1, number2)}");

int SumBetween(int num1, int num2)
{
    if (num1 == num2) return num1;
    SumBetween(num1 + 1, num2);
    return SumBetween(num1 + 1, num2) + num1;
}

   
