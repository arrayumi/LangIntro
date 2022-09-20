Console.Write("Введите целое число больше нуля: ");
int num = Convert.ToInt32 (Console.ReadLine());

int i = 1;

if (num >=1 )
{
while (i <= num)
{
 if (i%2 == 0)
 {
    Console.Write($"{i} ");
    i++;
 }
 else
 {
    i++;
 }
}
}
else
{
   Console.Write("Ошибка. Введите целое число больше нуля");
}
