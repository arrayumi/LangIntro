Console.Write("Введите первое целое число: ");
int number = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе целое число: ");
int square = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"Квадрат числа {number} = {square}?");
if ( square == number * number )
{
    Console.Write("да");
}
else
{
     Console.Write("нет");
}
