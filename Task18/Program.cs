// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string number = Console.ReadLine();

string FindRange(string num)
{
    string phrase = "Числа в диапазоне: ";
    if (num == "1") return $"{phrase} X > 0, Y > 0";
    if (num == "2") return $"{phrase} X < 0, Y > 0";
    if (num == "3") return $"{phrase} X < 0, Y < 0";
    if (num == "4") return $"{phrase} X > 0, Y < 0";
    return "Введите число от 1 до 4";
}

Console.WriteLine(FindRange(number));
