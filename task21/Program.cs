// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
string[] tochki = new string[3, 4];
tochki[0, 0] = "X";
tochki[0, 1] = "Y";
tochki[0, 2] = "Z";

tochki[1, 0] = "A";
tochki[2, 0] = "B";

for (int i = 1; i < 3; i++)
{
    Console.WriteLine($"Введите Координаты точки {tochki[i, 0]} :");
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine($"Введите Координату {tochki[0, j]} точки {tochki[i, 0]}: ");
        tochki[i, j] = Console.ReadLine();
    }
}

for (int i = 1; i < 3; i++)
{
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine($"{tochki[i, j]}");
    
    }
}