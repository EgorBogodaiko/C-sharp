// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
string[,] tochki = new string[4, 4];
int dist = default;
tochki[0, 1] = "X";
tochki[0, 2] = "Y";
tochki[0, 3] = "Z";

tochki[1, 0] = "A";
tochki[2, 0] = "B";
tochki[3, 0] = "temp";

for (int i = 1; i < 3; i++)
{
    Console.WriteLine($"Введите Координаты точки {tochki[i, 0]} :");
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine($"Введите Координату {tochki[0, j]} точки {tochki[i, 0]}: ");
        tochki[i, j] = Console.ReadLine();
    }
}


for (j = 1; j < 4; j++)
{
    tochki[3, j] = raznsqr(Convert.ToDouble(tochki[2, j]), Convert.ToDouble(tochki[1, j]));
}

dist = distance(tochki[1, 1], tochki[1, 2], tochki[1, 3]);
Console.WriteLine($"Расстояние между точками = {dist} ");

double distance(double x, double y, double z)
{
    double d = Math.Sqrt(x + y + z);
    return d;
}

double raznsqr(int a, int b)
{
    int razn = sqr(b - a);
    return razn;
}

int sqr(int num)
{
    int sqr = num * num;
    return sqr;
}

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.WriteLine($"{tochki[i, j]}");

//     }
//     Console.Write(" ");
// }