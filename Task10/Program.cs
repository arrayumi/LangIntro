// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число - {number}.");

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - (firstDigit * 100) - thirdDigit) / 10;
    return secondDigit;
}

if (number < 1000 && number > 99)
{
    int second = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} - {second}.");
}
else
{
    Console.WriteLine("Введите целое трехзначное число");
}