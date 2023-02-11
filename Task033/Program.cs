// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

bool FindElement(int number, int[] collection)
{
    foreach (int el in collection)
    {
        if (el == number) return true;
    }
    return false;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (FindElement(n, array))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
