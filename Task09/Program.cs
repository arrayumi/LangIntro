int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка[10, 99] - {number}.");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine("Цифры одинаковые");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} - {firstDigit} ");
// else Console.WriteLine($"Наибольшая цифра числа {number} - {secondDigit} ");

// int maxDigit = 0;
// if (firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit;

// тернарный оператор:
// int max = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine (max);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if (IsEqualDigits(firstDigit, secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString(): "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} - {result} ");