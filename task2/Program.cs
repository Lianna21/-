﻿// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// n = 3, m = 2 -> A(m,n) = 29
// n = 3, m = 11 -> A(m,n) = 16381

int FunctionOfAkkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FunctionOfAkkerman(n - 1, 1);
    }
    else
    {
        return FunctionOfAkkerman(n - 1, FunctionOfAkkerman(n, m - 1));
    }
}

int functionOfAkkerman = FunctionOfAkkerman(3, 11);
Console.WriteLine(functionOfAkkerman);