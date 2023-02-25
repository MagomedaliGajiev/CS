// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElOfInerval(int start, int end)
{
    if (end == start) return start;
    return end + SumElOfInerval(start, end - 1);
}

Console.Clear();

Console.Write("Введите начало интервала M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите конец интервала N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumElOfInerval(m, n));