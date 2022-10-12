// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] digits = new int[100];
string numstring;
int mis = 0;

Console.WriteLine("Введите число (до 100 символов) для проверки на палидромность:");
numstring = Console.ReadLine();
int size = numstring.Length;
for (int i = 0; i < size; i++)
{
    digits[i] = getdigit(numstring, i + 1);
}

for (int i = 0; i < (size / 2); i++)
{
    if ((digits[i]) != (digits[size - i-1]))
    {
        mis++;
    }
}

if (mis > 0)
{
    Console.WriteLine("Не палиндром");
}
else
{
    Console.WriteLine("Палиндром");
}


int getdigit(string numba, int count) 
{
    int sizenum = numstring.Length; 
    int intnumber = Convert.ToInt32(numba);
    int ii = 0;
    int thisDigit = default;
    while (ii < count)
    {
        thisDigit = intnumber / Convert.ToInt32(Math.Pow(10, (sizenum - 1)));         
        intnumber = intnumber - thisDigit * Convert.ToInt32(Math.Pow(10, (sizenum - 1)));
        ii++;
        sizenum--;
    }
    return thisDigit;
}

