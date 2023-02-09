// Решение в группах задач: Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

Console.Clear();

int[] GetArray()
{
    int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length - 1; i++)
    {
        Console.Write(collection[i]);
        if (i != collection.Length)
        Console.Write(",");
    }
}

int[] array = GetArray();
PrintArray(array);