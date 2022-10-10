// Задача 13: Напишите программу, которая выводит третью цифру  
//заданного числа или сообщает, что третьей цифры нет. 
 
// 645 -> 5 
 
// 78 -> третьей цифры нет 
 
// 32679 -> 6 
 
 
Console.WriteLine("Введите целое число: "); 
string stringnumber = (Console.ReadLine()); 
double size = stringnumber.Length; 
if (size > 2) 
{ 
    int intnumber = Convert.ToInt32(stringnumber); 
    int thisDigit = default; 
    int i=default; 
    while (i <3) 
        { 
            thisDigit = intnumber / Convert.ToInt32(Math.Pow(10, (size - 1))); 
            intnumber = intnumber - thisDigit * Convert.ToInt32(Math.Pow(10, (size - 1))); 
            i++; 
            size--; 
        } 
    Console.WriteLine($"Третья цифра этого числа = {thisDigit}"); 
} 
else 
{ 
    Console.WriteLine("Третьей цифры нет"); 
}