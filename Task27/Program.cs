// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = default;
    while (num > 9) // >=9 - почему программа работает корректно?
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    sum = sum + num;
    return sum;
}

Console.WriteLine(SumDigits(number));
