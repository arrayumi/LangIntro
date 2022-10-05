// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int PositiveIntCounter (int [] array)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

Console.Write("Введите количество чисел, которые хотите ввести: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите {num} чисел через пробел: ");

int [] arr = new int [num];
arr = Console.ReadLine().Split(" ", num).Select(int.Parse).ToArray();
Console.WriteLine ($"Введено {PositiveIntCounter(arr)} чисел больше 0.");