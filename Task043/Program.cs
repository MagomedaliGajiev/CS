// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string GetCoordinates(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) return "Прямые не пересекаются";
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    string result = $"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x:f2}; {y:f2})";
    return result;
}

Console.Clear();

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetCoordinates(b1, k1, b2, k2));