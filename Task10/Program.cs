// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число - {number}.");

// !!!!! Невнимательно прочитала условия задачи и нашла вторую цифру числа. Пусть будет. 
//
//
//int SecondDigit(int num)
// {
//     int firstDigit = num / 100;
//     int thirdDigit = num % 10;
//     int secondDigit = (num - (firstDigit * 100) - thirdDigit) / 10;
//     return secondDigit;
// }

// int second = SecondDigit(number);
// Console.WriteLine($"Вторая цифра числа {number} - {second}.");

int NoSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int res = NoSecondDigit(number);
Console.WriteLine(res);