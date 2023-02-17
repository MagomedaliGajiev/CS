// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = { 1, 2, 3, 55 };

int[] copiedArray = CopyArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", copiedArray));