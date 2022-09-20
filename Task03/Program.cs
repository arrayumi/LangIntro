Console.Write("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32 (Console.ReadLine());

if ( number < 8 && number > 1 )
{
   if (number == 1)
   {
    Console.Write("понедельник");
   }
    if (number == 2)
   {
    Console.Write("вторник");
   }
    if (number == 3)
   {
    Console.Write("среда");
   }
    if (number == 4)
   {
    Console.Write("четверг");
   }
    if (number == 5)
   {
    Console.Write("пятница");
   }
    if (number == 6)
   {
    Console.Write("суббота");
   }
    if (number == 7)
   {
    Console.Write("воскресенье");
   }
}
else 
{
     Console.Write("Ошибка. Перезапустите программу и введите целое число от 1 до 7");
}
