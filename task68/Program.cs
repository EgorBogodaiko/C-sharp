// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое целое положителное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положителное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if((number1<0)||(number2<0)) Console.WriteLine("Какое-то из чисел не положительное.");
else if ((number1>4)&&(number2>0)) Console.WriteLine("Получится слишком большое число для вывода здесь. Будет переполнение типа.");
else
Console.WriteLine($"Функция Аккермана А({number1},{number2}) = {Akkerman(number1, number2)}");

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if ((n == 0)) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
    
}