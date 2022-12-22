/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = 4, n = 8;

Console.Write($"{Summ(m, n)}");

int Summ(int left, int right)
{
    if (left >= right)
        return left;
    return left + Summ(left + 1, right);
}