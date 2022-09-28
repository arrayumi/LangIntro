// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите размер массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите диапазон чисел в массиве:");
Console.Write("от A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("до B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrLength];


void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        Random rnd = new Random();
        arr[index] = rnd.Next(numA, numB);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{arr[i]}, ");
        i++;
    }
}

if (numB < numA) Console.Write("B должно быть больше A");
else
{
    Console.Write("[");
    FillArray(array);
    PrintArray(array);
    Console.Write("]");
}