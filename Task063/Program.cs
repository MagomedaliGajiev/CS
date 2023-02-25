// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string GetInterval(int number)
{
    string result = string.Empty;
    if (number == 1) return  result += $"{number}";
    return result += GetInterval(number - 1) + $", {number}";

}

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);


Console.WriteLine($"N = {n} -> {GetInterval(n)}");