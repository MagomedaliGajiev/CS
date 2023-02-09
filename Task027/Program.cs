// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 
// 82 -> 10
// 9012 -> 12

Console.Clear();

int GetSumOfDigits(int number)
{
    int sum = 0;
    while (number / 10 != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    sum += number;
    return sum;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {N} равна {Math.Abs(GetSumOfDigits(N))}");
