// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string PrintInterval(int m, int n)
{
    string result = String.Empty;
    if (n == m) return result += $"{m}";
    return result += PrintInterval(m, n - 1) + $", {n}";
}

Console.Clear();

Console.Write("Введите начало интервала M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите конец интервала N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {m}; N = {n} -> {PrintInterval(m, n)}");

