// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] MatrixMinElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int iMin = 0, jMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    return new int[] { iMin, jMin };
}

int[,] DeleteRowColumnOfMinElement(int[,] matrix, int[] indexMin)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int iNew = 0; int jNew = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexMin[0]) i++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == indexMin[1]) j++;
            newMatrix[iNew, jNew] = matrix[i, j];
            jNew++;
        }
        iNew++;
        jNew = 0;
    }

    return newMatrix;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

PrintMatrix(DeleteRowColumnOfMinElement(array2D, MatrixMinElement(array2D)));