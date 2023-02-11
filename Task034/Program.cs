// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int CountEvenNumbers(int[] collection)
{
    int result = 0;
    foreach (int item in collection)
    {
        result += item % 2 == 0 ? 1 : 0;
    }
    return result;
}

int[] myArray = GetArray(new Random().Next(3, 13), 100, 1000); // Задаем массив размерностью от 3 до 12 с трехзначными числами
int evenNumbers = CountEvenNumbers(myArray);
Console.WriteLine($"[{String.Join(", ", myArray)}] -> {evenNumbers}");