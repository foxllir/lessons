/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int a, b;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine(), out b);

if (b == 0)
    Console.WriteLine(1);
else
{
    int ans = a;
    for (int i = 0; i < b - 1; i++)
        ans *= a;
    Console.WriteLine(ans);
}