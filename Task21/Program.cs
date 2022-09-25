// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

int Square(int num)
{
    return num * num;
}

double Distance(int argXA, int argYA, int argZA, int argXB, int argYB, int argZB)
{
    double res = Math.Sqrt(Square(argXA - argXB) + Square(argYA - argYB) + Square(argZA - argZB));
    double roundRes = Math.Round(res, 2, MidpointRounding.ToZero);
    return roundRes;
}

double result = Distance(xa, ya, za, xb, yb, zb);
System.Console.WriteLine($"Расстояние между точкой А и точкой В -> {result}");