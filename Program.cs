/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

string[] numbers = Console.ReadLine()!.Split(' ');
int[] array = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    int.TryParse(numbers[i], out array[i]);
    Console.Write($"{array[i]} ");
}

int k = 0;
foreach (var i in array)
    if (i > 0)
        k++;

Console.Write($"\n{k} чисел больше 0");