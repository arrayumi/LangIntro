// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите стороны треугольника:");
Console.Write("A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool CheckIfTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

if (CheckIfTriangleExist(numberA, numberB, numberC)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник с такими сторонами не может существовать");