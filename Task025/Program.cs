// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// Реализовать функцию возведения в степень самостоятельно!

Console.Clear();

int GetDegree(int A, int B)
{

    int prod = A;
    for (int i = 1; i < B; i++)
    {
        prod *= A;
    }
    return prod;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} в {B} степени равно {GetDegree(A, B)}");