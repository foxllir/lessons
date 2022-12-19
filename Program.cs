/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] array = new int[3, 3];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
}
Console.WriteLine();

int iu, ju;
Console.Write($"Введите i: ");
int.TryParse(Console.ReadLine(), out iu);
Console.Write($"Введите j: ");
int.TryParse(Console.ReadLine(), out ju);

if (iu >= 0 && iu < array.GetLength(0) && ju >= 0 && ju < array.GetLength(1))
    Console.Write($"[{iu},{ju}] = {array[iu, ju]}");
else
    Console.Write($"Неверный ввод индексов");