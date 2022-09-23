// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 999) num = num / 10;
    int thirdDigit = num % 10;
    return thirdDigit;
}

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} - {result}.");
}