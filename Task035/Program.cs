// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
//  [5, 18, 123, 6, 2] -> 1
//  [1, 2, 3, 6, 2] -> 0
//  [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

int CountElements(int[] array, int minValue, int maxValue)
{
    int count = 0;
    foreach (int el in array)
    {
        count += el >= minValue && el <= maxValue ? 1 : 0;
    }
    return count;
}

int[] myArray = GetArray(123, -9, 150);
Console.WriteLine($"[{String.Join(", ", myArray)}] -> {CountElements(myArray, 10, 99)}");
