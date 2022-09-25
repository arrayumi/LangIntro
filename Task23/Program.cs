// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

void TableCube(int num)
{
    int count = 1;
    if (num > 0)
    {
        while (count <= num)
        {
            Console.WriteLine($"|{count,3}|{count * count * count,5}|");
            count++;
        }
    }
    else Console.Write("Ошибка. Введите число больше нуля.");
}

TableCube(number);
