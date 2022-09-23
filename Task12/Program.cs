// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32 (Console.ReadLine());

int check = firstNumber % secondNumber;
if (firstNumber > secondNumber)
{
if (check > 0)
{
    Console.WriteLine($"Не кратно. Остаток {check}");
}
else
{
    Console.WriteLine("Кратно");
}
}
else
{
  Console.WriteLine("Не кратно. Второе число больше первого.");
}
