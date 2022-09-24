// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, соответствующую дню недели (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());

bool WeekdayCheck(int num)
{
    return (num == 6 || num == 7);
}

if (number > 0 && number < 8)
{
    if (WeekdayCheck(number)) Console.WriteLine("Это выходной");
    else Console.WriteLine("Этот день не является выходным");
}
else Console.WriteLine("Ошибка. Введите цифру от 1 до 7");