// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


int[] MultiplyPairsArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;

    int[] array2 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 == 1) array2[size - 1] = array[size - 1];
    
    return array2;
}

int[] arr = CreateArrayRndInt(13, -9, 9);
PrintArray(arr);
int[] arr2 = MultiplyPairsArray(arr);
PrintArray(arr2);