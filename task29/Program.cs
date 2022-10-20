// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Придумаю массив из 8 чисел в диапазоне от 1 до 40:");

int[] numbers = new int[8];
void FillArray(int[] array)
{
    Random rnd = new Random();
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 41);
    }
    
}
void PrintArray(int[] array)
{
    int size = array.Length;
    Console.Write($"[{array[0]}");
    for (int i = 0; i < size; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine($"]");
}

FillArray(numbers);
PrintArray(numbers);