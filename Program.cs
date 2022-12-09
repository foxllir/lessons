/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int a;
Console.Write($"Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out a);
string num = a.ToString();

if (num.Length < 3)
    Console.Write($"Третьей цифры нет");
else
{
    Console.Write($"{a} -> {num[2]}");
}