﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int EvenNumCounter (int [] array)
{
    int counter = default;
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i]%2 == 0) counter++;
 }   
 return counter;
}

int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);
int count = EvenNumCounter (arr);
Console.WriteLine ($"Количество чётных чисел в массиве -> {count}");