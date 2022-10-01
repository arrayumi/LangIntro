// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

// void FindNumber(int[] array, int num)
// {
//     int i = 0;
//     int res = 0;
//     while (i < array.Length)
//     {
//         if (num != array[i])
//         {
//             res = 0;
//             i++;
//         }
//         else
//         {
//             res = 1;
//             break;
//         }
//     }
//     if (res == 0) Console.Write($"Число {num} не присутствует в массиве ");
//     else Console.Write($"Число {num} присутствует в массиве ");
// }

bool FindNumber1(int[] array, int num)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            res = true;
            break;
        }
    }
    return res;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(12, -9, 9);
if (FindNumber1(arr, number)) Console.Write($"Число {number} присутствует в массиве ");
else Console.Write($"Число {number} не присутствует в массиве ");
PrintArray(arr);