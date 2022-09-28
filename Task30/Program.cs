// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write ("Введите размер массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrLength];

void Array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random ();
        array[i] = rnd.Next(0, 2);
        Console.Write($"{array[i]}, ");
    }
}

Console.Write ("[");
Array(array);
Console.Write ("]");