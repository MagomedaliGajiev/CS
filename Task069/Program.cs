// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А
// в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetPow(int a, int b)
{
    int result = 1;
    if (b == 0) return result;
    return result *= a * GetPow(a, b - 1);
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!); 

Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{number} в степени {power} равно {GetPow(number, power)}");