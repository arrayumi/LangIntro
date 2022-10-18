// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 5;

void NaturalNumbers(int num)
{
    if (num==0) return;
    NaturalNumbers(num - 1);
    Console.Write ($"{num} ");
}

void NaturalNumbers2(int num)
{
    if (num==0) return;
    Console.Write ($"{num} ");
    NaturalNumbers2(num - 1);
}

NaturalNumbers(n);
Console.WriteLine();
NaturalNumbers2(n);