// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void PalindromeCheck(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 % 10;
    int fourthDigit = number / 10 % 10;
    int fifthDigit = number % 10;

    if (number > 9999 && number < 100000)
    {
        if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.Write($"Число {number} - палиндром.");
        else Console.Write($"Число {number} не является палиндромом.");
    }
    else Console.Write("Ошибка. Введите целое пятизначное число.");
}
PalindromeCheck(num);