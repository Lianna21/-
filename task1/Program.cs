
﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

void NaturalNumbersBetweenMN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }

    Console.Write($"{m}, ");
    NaturalNumbersBetweenMN(m + 1, n);
}

void NaturalNumbersBetweenNM(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }

    Console.Write($"{m}, ");
    NaturalNumbersBetweenNM(m - 1, n);
}

void Examination(int m, int n)
{
    if (m < n)
    {
        NaturalNumbersBetweenMN(m, n);
    }
    else if (m > n)
    {
        NaturalNumbersBetweenNM(m, n);
    }
    else
    {
        Console.Write(n); // or "m", becouse m = n
    }
}

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

Examination(m, n);