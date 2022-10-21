//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Будем искать координаты точки пересечения двух прямых.");
System.Console.WriteLine("Есть функция прямой 1: Y = K1*X + B1");
System.Console.Write("Извольте ввести K1: ");
int ka1=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Извольте ввести B1: ");
int be1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" ");
System.Console.WriteLine("Есть функция прямой 2: Y = K2*X + B2");
System.Console.Write("Извольте ввести K2: ");
int ka2=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Извольте ввести B2: ");
int be2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" ");
System.Console.Write("Точка пересечения: ");
if (ka1==ka2)
{
  System.Console.Write("не существует, ибо параллельны прямые.");  
}
else
{
    System.Console.Write($"X = {DotCrossLinesX(ka1,be1,ka2,be2)}, Y = {DotCrossLinesY(DotCrossLinesX(ka1,be1,ka2,be2),ka1,be1)}");
}


double DotCrossLinesX (int k1, int b1,int k2,int b2)
{
var x=(double)(b2-b1)/(k1-k2);
return x;
}

double DotCrossLinesY (double x, int k,int b)
{
var y =(double) k*x + b;
return y;
}