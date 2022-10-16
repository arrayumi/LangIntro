// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] Multiply2Matrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int k = 0; k < result.GetLength(1); k++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return result;
}

int[,] matrixA = CreateMatrixRndInt(5, 2, 1, 5);
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = CreateMatrixRndInt(2, 4, 1, 5);
PrintMatrix(matrixB);
Console.WriteLine();

if (matrixA.GetLength (1) == matrixB.GetLength (0))
{
Console.WriteLine("Результат умножения матриц: ");
int[,] matrixC = Multiply2Matrix(matrixA, matrixB);
PrintMatrix(matrixC);
}
else Console.WriteLine ("Количество столбцов 1-й матрицы должно совпадать с количеством строк 2-й.");