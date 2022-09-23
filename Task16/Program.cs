// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// int Square (int num1, int num2)
// {
//     int result = 0;
//     if (num1*num1 == num2 || num2*num2 == num1) result = 1;
//     return result;
// }

// int res = Square (firstNumber, secondNumber);
// if (res == 1)
// {
//     Console.Write("Одно число является квадратом другого");
// }
// else
// {
//     Console.Write ("Ни одно число не является квадратом другого");
// }


bool Square (int num1, int num2)
{
    return (num1 * num1 == num2 || num2 * num2 == num1);
}

if (Square (firstNumber, secondNumber)) Console.Write("Одно число является квадратом другого");
else Console.Write ("Ни одно число не является квадратом другого");


// void Square(int num1, int num2)
// {
//     if (num1 * num1 == num2 || num2 * num2 == num1)
//     {
//         Console.Write("Одно число является квадратом другого");
//     }
//     else
//     {
//         Console.Write("Ни одно число не является квадратом другого");
//     }
// }

// Square(firstNumber, secondNumber);
