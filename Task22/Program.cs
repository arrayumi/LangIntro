// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// int square = 1;
// if (number > 0)
// {
// while (count <= number) 
// {
//     square = count*count;
//     Console.WriteLine ($"{count}     {square}");
//     count++;
// }
// }
// else Console.Write ("Ошибка. Введите число больше нуля.");



void TableSquare(int num)
{
    int count = 1;
    if (num > 0)
    {
        while (count <= num)
        {
            Console.WriteLine($"|{count, 3}|{count * count, 3}|");
            count++;
        }
    }
    else Console.Write("Ошибка. Введите число больше нуля.");
}

TableSquare(number);