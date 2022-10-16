// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinSumRow(int[,] matrix)
{
    int sum = default;
    int minSum = Int32.MaxValue;
    int rowNumber = 1;
    int minRowNumber = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRowNumber = rowNumber;
        }

        sum = 0;
        rowNumber++;
    }
    return minRowNumber;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 3);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0) != array2D.GetLength(1)) Console.WriteLine($"{MinSumRow(array2D)} строка");
else Console.WriteLine("Количество строк и столбцов не должны совпадать");