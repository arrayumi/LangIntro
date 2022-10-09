// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void CheckElement(int[,] matrix, int row, int column)
{
    if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) Console.Write("Такого элемента нет.");
    else Console.Write($"Значение элемента с введенными позициями -> {matrix[row - 1, column - 1]}");
}

// Задача выполнена с учетом того, что пользователь ведет счет строчек и столбцов начиная с 1.

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

Console.WriteLine("Введите строку, на которой находится элемент: ");
int rowElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец, на котором находится элемент: ");
int columnElement = Convert.ToInt32(Console.ReadLine());

CheckElement(array2D, rowElement, columnElement);