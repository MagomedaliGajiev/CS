// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:              Новый массив будет выглядеть вот так:
// 1 4 7 2                                                     1 4 49 2
// 5 9 2 3                                                     5 81 2 9 
// 8 4 2 4                                                     64 4 4 4

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void GetSqrArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) inArray[i, j] *= inArray[i, j];
        }
    }
}

Console.Clear();

int[,] array2d = GetArray(3, 4, 1, 9);
PrintArray(array2d);
GetSqrArray(array2d);
System.Console.WriteLine();
PrintArray(array2d);