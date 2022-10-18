// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = num % 10;
    if (num > 0) return sum + SumDigit(num / 10);
    return sum;
}

Console.WriteLine(SumDigit(n));