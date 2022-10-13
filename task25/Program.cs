// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите целое число, которое будет основанием степени:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число, которое будет показателем степени:");
int b = Convert.ToInt32(Console.ReadLine());
double expo=default;
Console.WriteLine($"Число {a}  в степени {b} = ");

if ((b == 0)&&(a!=0)) Console.WriteLine("1");
if (a == 1) Console.WriteLine("1");

if ((b!=0)&&(a!=1))
{
    expo = Expo(a,b);
    Console.WriteLine($"{expo}");
}

double Expo(int numA, int numB)
{
    double result = numA;
    for (int i = 1; i < Math.Abs(numB); i++)
    {
        result = numA * result;
    }
    if (numB<0) result=1/result;
    return result;
}