// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArrayRnd(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if
        (i < arr.Length - 1)
        {
            System.Console.Write($"{arr[i]}, ");
        }
        else
        {

            System.Console.Write($"{arr[i]}");
        }
    }
    System.Console.WriteLine("]");
}

int CountInt(int[] arr)
{
    int counter = default;
    for (int i = 0; i < arr.Length; i++)
    {
       
        if (arr[i]%2==0)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = new int[10];
FillArrayRnd(array, 100, 999);
PrintArray(array);
System.Console.WriteLine($"В массиве содержится {CountInt(array)} чётных числа");