// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

// k1*x +b1 = k2*x +b2; k1*x -k2*x = b2 - b1; (k1-k2)x = b2-b1; x = (b2 - b1) / (k1-k2);   
void PointOfIntersection(double a, double b, double c, double d)
{
    if (b == d) Console.WriteLine("Введены неверные значения. k1 и k2 не должны совпадать.");
    else
    {
        double x = Math.Round((c - a) / (b - d), 2);
        double y = Math.Round(b * x + a, 2);
        Console.WriteLine($"({x}, {y})");
    }
}

PointOfIntersection (b1, k1, b2, k2);