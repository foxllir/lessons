/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int s = 0; s < array.GetLength(0); s++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array[s, i];
        int j = i - 1;

        while (j >= 0 && array[s, j] > k)
        {
            array[s, j + 1] = array[s, j];
            array[s, j] = k;
            j--;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++) ;