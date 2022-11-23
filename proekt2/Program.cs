/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) 

{
    txtResult = $". Этот день недели - выходной!";
}

else txtResult = $", рабочий день недели.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();
