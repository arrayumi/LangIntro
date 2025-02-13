﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNum(int num)
{
    if (num < 0) num = -num;
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

int countNum = default;
if (number != 0) countNum = CountNum(number);
else countNum = 1;
Console.WriteLine($"Количество цифр в числе {number} -> {countNum}");
