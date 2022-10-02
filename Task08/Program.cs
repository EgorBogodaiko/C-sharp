//  Напишите программу, которая на вход принимает
//  число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число, желательно положительное: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1)
{
    Console.WriteLine("Введённое число меньше 2, поэтому чётных чисел от 1 до N не существует");
}
else
{
    Console.WriteLine($"Чётные числа, которые есть от 1 до {number}: ");

    for (int i = 2; i <= number; i += 2)
    {
        Console.WriteLine(i);
    }
}