// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

Console.Clear();
int DigitCount(int A)
{
    int count = 0;
    if (A == 0)
    {
        count = 1;
    }
    else
    {
        while (A != 0)
        {
            A /= 10;
            count++;
        }
    }
    return count;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр числа {N} равно {DigitCount(N)}");