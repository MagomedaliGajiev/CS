﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("m и n должны быть положительными!");
        return -1;
    }
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAckermann(m - 1, 1);
    return GetAckermann(m - 1, GetAckermann(m, n -1));
}

Console.Clear();

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({m},{n}) = {GetAckermann(m, n)}");