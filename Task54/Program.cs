// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}| ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[,] SortRowFromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {
            for (int sortedJ = matrix.GetLength(1) - 1; sortedJ > 0; sortedJ--)
            {
                if (matrix[i, sortedJ] > matrix[i, sortedJ - 1])
                {
                    int temp = matrix[i, sortedJ];
                    matrix[i, sortedJ] = matrix[i, sortedJ - 1];
                    matrix[i, sortedJ - 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] array2D = CreateMatrixRndInt(7, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

PrintMatrix(SortRowFromMaxToMin(array2D));