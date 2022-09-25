// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Write("Введите координаты точки в плоскости X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки в плоскости Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int XY(int arg1, int arg2)
{
    int answer = 0;
    if (arg1 > 0 && arg2 > 0) answer = 1;
    if (arg1 < 0 && arg2 > 0) answer = 2;
    if (arg1 < 0 && arg2 < 0) answer = 3;
    if (arg1 > 0 && arg2 < 0) answer = 4;
    return answer;
}

int result = XY(x, y);
if (x == 0 || y == 0) Console.WriteLine("Ошибка. X и Y не должны быть равны нулю");
else Console.WriteLine(result);
