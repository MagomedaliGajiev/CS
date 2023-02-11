// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 2);
    }
    return array;
}

double GetMax(double[] collection)
{
    double max = collection[0];
    foreach (double el in collection)
    {
        max = el > max ? el : max;
    }
    return max;
}

double GetMin(double[] collecion)
{
    double min = collecion[0];
    foreach (double el in collecion)
    {
        min = el < min ? el : min;
    }
    return min;
}

double[] arr = GetArray(new Random().Next(3, 8), 1.01, 99.99); // Создаем массив с вещественными числами размерностью от 3 до 7
double result = GetMax(arr) - GetMin(arr);
Console.WriteLine($"[{String.Join("; ", arr)}] -> {result:f2}");