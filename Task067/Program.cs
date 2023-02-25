// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetSumOfDigits(int number)
{
    int sumOfDigits = 0;
    if (number == 0) return sumOfDigits;
    return sumOfDigits += number % 10 + GetSumOfDigits(number / 10);
}

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{num} = {GetSumOfDigits(num)}");