﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int QuantityOfElements(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 9 && array[i] < 100) counter++;
    return counter;
}

int[] arr = CreateArrayRndInt(122, 1, 500);
PrintArray (arr);
int count = QuantityOfElements(arr);
Console.WriteLine();
Console.WriteLine ($"Количество элементов массива, значения которых лежат в отрезке [10,99] -> {count}");
