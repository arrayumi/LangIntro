﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateArray3DRndInt(int rows, int columns, int depth, int[] array) // принимаем на вход одномерный массив
{                                                                          // из неповторяющихся чисел     
    int[,,] matrix = new int[rows, columns, depth];
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[l];
                l++;
            }
        }
    }
    return matrix;
}

void PrintArray3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[] NotRepeatedNumbers(int size, int min, int max) // создаем одномерный массив с неповторяющимися числами
{
    int[] array = new int[size];
    var rnd = new Random();
    array[0] = 10;
    int check = default;
    for (int i = 1; i < size; i++)
    {
        check = rnd.Next(min, max + 1);

        for (int j = 0; j < i; j++)
        {
            if (array[j] == check) { i--; break; }
            else array[i] = check;
        }
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

int[] arr = NotRepeatedNumbers(90, 10, 99);
//PrintArray(arr);

// Е.к. у нас в массиве должны быть двузначные неповторяющиеся числа, то произведение всех измерений 
// должно быть не больше 90, чтобы условие выполнялось (иначе программа выдает ошибку).
// Было принято решение вынести измерения в отдельные переменные, чтобы произвести проверку

int rowsArr3D = 5, columnsArr3D = 3, depthArr3D = 3;
if (rowsArr3D * columnsArr3D * columnsArr3D < 90)
{
    int[,,] arr3D = CreateArray3DRndInt(rowsArr3D, columnsArr3D, depthArr3D, arr);
    PrintArray3D(arr3D);
}
else Console.WriteLine("Массив слишком большой, невозможно его заполнить неповторяющимися числами");