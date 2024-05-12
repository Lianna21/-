﻿// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] arr = { 1, 2, 5, 0, 10, 34 };

void OutputtingReverseArray(int[] arr, int count = 1)
{
    if (arr.Length == count - 1)
    {
        return;
    }

    Console.Write($"{arr[arr.Length - count]} ");
    OutputtingReverseArray(arr, count + 1);
}

OutputtingReverseArray(arr);