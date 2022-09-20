Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32 (Console.ReadLine());

int numMax = a;
if (b > numMax)
{
numMax = b;
}
else 
{
numMax = a;
}
if (c > numMax)
{
numMax = c;
}
else
{
    numMax = a;
}
Console.Write(numMax);