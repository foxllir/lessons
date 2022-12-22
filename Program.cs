/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int n = 10;

Console.Write($"{PrintNums(n, 1)}");

string PrintNums(int left, int right)
{
    if (left <= right)
        return left.ToString();
    return $"{left} {PrintNums(left - 1, right)}";
}