// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] Multi(int[] myArray)
{
    int size = myArray.Length / 2;
    if (myArray.Length % 2 != 0) size++;
    int[] newArray = new int[size];

    for (int i = 0; i < myArray.Length / 2; i++)
    {
        newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
    }
    if (myArray.Length % 2 != 0) newArray[size - 1] = myArray[myArray.Length / 2];
    return newArray;
}

int[] arr = GetArray(new Random().Next(4, 13), 0, 10);

int[] newArr = Multi(arr);
Console.WriteLine($"[{String.Join(", ", arr)}] -> {String.Join(" ", newArr)}");