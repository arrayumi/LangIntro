// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    int i = 0, j = 0;
    int num = 1;

    int maxRow = matrix.GetLength(0), maxColumn = matrix.GetLength(1);

    while (num < matrix.Length)
    {
        for (i = 0, j = 0; j < maxColumn; j++)
        {
            matrix[i, j] = num;
            num++;
        }

        maxColumn--;
        for (i++, j = maxColumn; i < maxRow; i++)
        {
            matrix[i, j] = num;
            num++;
        }

        maxRow--;
        maxColumn--;
        for (i = maxRow, j = maxColumn; j >= 0; j--)
        {
            matrix[i, j] = num;
            num++;
        }

        maxRow--;
        for (i = maxRow, j = 0; i > 0; i--)
        {
            matrix[i, j] = num;
            num++;
        }

        maxColumn++;
        for (i++, j++; j < maxColumn; j++)
        {
            matrix[i, j] = num;
            num++;
        }

        for (i=2, j=2; j > 0; j--)
        {
            matrix[i, j] = num;
            num++;
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

int[,] array2D = CreateMatrixRndInt(4, 4, 2, 5);
PrintMatrix(array2D);