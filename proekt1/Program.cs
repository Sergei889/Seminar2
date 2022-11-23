/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int Number = new Random().Next(1, 5000);
Console.WriteLine($"Дано число: {Number}");

if (Number / 100 < 1) Console.WriteLine($"У числа {Number} нет третьей цифры");
else
{
    if (Number / 1000 > 0) Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
    else Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
}

Console.WriteLine();
