// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Первое число для проверки на кратность: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число для проверки на кратность: ");
int second = Convert.ToInt32(Console.ReadLine());

// int Result(int num, int num1, int num2)
// {
//     int result = 1;
//     if (num % num1 == 0 && num % num2 == 0) result = 0;
//     return result;
// }

// int res = Result(number, first, second);
// if (res == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

bool Multiple(int arg1, int arg2)
{
    return (arg1 % arg2 == 0);
}

if (Multiple(number, first) && Multiple(number, second)) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");