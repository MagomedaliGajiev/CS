// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetFibonacciNumbers(int number)
{
    int[] result = new int[number];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 2] + result[i - 1];
    }
    return result;
}

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int[] myArray = GetFibonacciNumbers(n);
Console.WriteLine($"Если N = {n} -> {String.Join(" ", myArray)}");