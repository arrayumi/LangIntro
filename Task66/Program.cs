// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numM, int numN)
{
    int sum = numN;
    if (numM <= numN) return sum + SumNumbers(numM, numN - 1);
    return 0;
}

if (m < n) Console.Write(SumNumbers(m, n));
else if (m > n) Console.Write(SumNumbers(n, m));
else Console.Write("0");
