Console.Write("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32 (Console.ReadLine());

switch (number)
{
case 1:
    Console.Write("понедельник");
    break;
case 2:
    Console.Write("вторник");
    break;
case 3:
    Console.Write("среда");
    break;
case 4:
    Console.Write("четверг");
    break;
case 5:
    Console.Write("пятница");
    break;
case 6:
    Console.Write("суббота");
    break;
case 7:
    Console.Write("воскресенье");
    break;
default:
Console.Write("Ошибка. Перезапустите программу и введите целое число от 1 до 7");
    break;
}