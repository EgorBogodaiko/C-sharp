//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayRnd(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, int index)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i += index)
    {
        if
        (i < arr.Length - index)
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

int[] array = new int[10];
FillArrayRnd(array, 100, 999);
System.Console.WriteLine($"Исходный массив:");
PrintArray(array, 1);
System.Console.WriteLine($"Каждый нечётный элемент массива:");
PrintArray(array, 2);
