// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Expo(int numA, int numB)
{
    int result = 1;
    for (int counter = 1; counter <= numB; counter++)
    {
        result = result * numA;
    }
    return result;
}

int res = numberB == 0 ? res = 1 : res = Expo(numberA, numberB);
Console.WriteLine(res);
