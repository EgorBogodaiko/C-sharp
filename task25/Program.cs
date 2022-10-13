// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Writeline("Введите целое число, которое будет основанием степени:");
int a = Convert.ToInt32(Console.Readline());
Console.Writeline("Введите целое число, которое будет показателем степени:");
int b = Convert.ToInt32(Console.Readline());
int expo=default;
Console.Writeline($"Число {a}  в степени {b} = ");
if (b == 0) Console.Writeline("1");
if (b == 1) Console.Writeline("1");
if ((b!=0)&&(b!=1))
{
    expo = Expo(a,b);
    Console.Writeline($"{expo}");
}


int Expo(int numA, int numB)
{
    int result = numA;
    for (int i = 0; i < numB; i++)
    {
        result = numA * result;
    }
    return result;
}