// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ConvertToBinary(int num)
{
    string bin = default;
    if (num > 0)
    {
        bin += num%2;
        ConvertToBinary (num/2);
    }
    Console.Write (bin);
}

void ConvertToBinary2(int num)
{
    if (num > 0) ConvertToBinary (num/2);
    Console.Write (num%2);
}

ConvertToBinary2(number);