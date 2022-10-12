// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int[] digits = new int(100);
string numstring;
int numint = default;
int size = default;
Console.WriteLine("Введите число (до 100 символов) для проверки на палидромность:");
Console.ReadLine(numstring);
numint = Convert.ToInt32(numstring);


for (int i = 0; i < size; i++)
{
    digits[i] = getdigit(numint, i);
}



int getdigit(string numba, int count)
{
    int size = numstring.Length;
    int intnumber = Convert.ToInt32(numba);
    int ii = 0;
    while (ii < count)
    {
        int thisDigit = intnumber / Convert.ToInt32(Math.Pow(10, (size - 1)));
        intnumber = intnumber - thisDigit * Convert.ToInt32(Math.Pow(10, (size - 1)));
        i++;
        size--;
    }

    return thisDigit;
}