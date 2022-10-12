// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
string[,] tochki = new string[4, 4];
double dist = default;
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

for (int j = 1; j < 4; j++)
{
    tochki[3, j] = Convert.ToString(raznsqr(Convert.ToDouble(tochki[2, j]), Convert.ToDouble(tochki[1, j])));
}

dist = Math.Round(distance(tochki[3, 1], tochki[3, 2], tochki[3, 3]),2);
Console.WriteLine($"Расстояние между точками = {Convert.ToString(dist)}");

double distance(string x, string y, string z)
{
    double x1= Convert.ToDouble(x);
    double y1= Convert.ToDouble(y);
    double z1= Convert.ToDouble(z);

    double d = Math.Sqrt(x1 + y1 + z1);
    return d;
}

double raznsqr(double a, double b)
{
    double razn = sqr(Convert.ToInt32( b )- Convert.ToInt32( a));
    return razn;
}

int sqr(int num)
{
    int sqr = num * num;
    return sqr;
}
