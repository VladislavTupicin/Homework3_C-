﻿//Задача 23
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 3)}  ");
    count ++;
}
Console.WriteLine();