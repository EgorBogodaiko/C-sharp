// Напишите программу, которая принимает на вход  
//трёхзначное число и на выходе показывает вторую цифру этого числа. 
 
// 456 -> 5 
// 782 -> 8 
// 918 -> 1 
 
Console.WriteLine("Введите целое трёхзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
 
int firstDigit = number/100; 
int twoDigitsNumber = number - 100*firstDigit; 
int secondDigit = twoDigitsNumber/10; 
 
Console.WriteLine($"Второе число={secondDigit}");