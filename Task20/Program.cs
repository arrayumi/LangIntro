// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int arg1, int arg2, int arg3, int arg4)
{
    int sideA = arg1 - arg3;
    int sideB = arg2 - arg4;
    double res = Math.Sqrt(sideA * sideA + sideB * sideB);
    double roundRes = Math.Round (res, 2, MidpointRounding.ToZero);
    return roundRes;
}

double result = Distance (xa, ya, xb, yb);
System.Console.WriteLine($"Расстояние между точкой А и точкой В -> {result}");