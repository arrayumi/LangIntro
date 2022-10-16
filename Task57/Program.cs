// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] GetArrayFromMatrix(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
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

int CounterUniqueValues(int[] array)
{
    int counter = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[i - 1]) counter++;
    }
    return counter;
}

int[,] ValueCounterMatrix(int[] array)
{
    int[,] matrix = new int[CounterUniqueValues(array), 2];
    int counter = 1;
    int i = 0, j = 0, k = default;
    for (k = 1; k < array.Length; k++)
    {
        if (array[k] > array[k - 1])
        {
            matrix[i, j] = array[k - 1];
            matrix[i, j + 1] = counter;
            counter = 0;
            j = 0;
            i++;
        }
        counter++;
    }

    matrix[i, j] = array[k - 1];
    matrix[i, j + 1] = counter;

    return matrix;
}

void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} повторяется ");
            else Console.Write($"{matrix[i, j]} раз");
        }
        Console.WriteLine();
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] arr = GetArrayFromMatrix(array2D);
PrintArray(arr);
Console.WriteLine();

Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();

int[,] valueCounterMatrix = ValueCounterMatrix(arr);
PrintMatrix2(valueCounterMatrix);