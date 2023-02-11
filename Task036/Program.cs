// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetSumOfElOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += i % 2 != 0 ? arr[i] : 0;
    }
    return sum;
}

int[] array = GetArray(new Random().Next(3, 8), -99, 99); // Задаем массив размерностью от 3 до 7 с числами от -99 до 99
int sum = GetSumOfElOddPos(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {sum}");