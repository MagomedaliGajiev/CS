// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray2D(int rows, int columns, int minValue, int maxValue)
{
    int[,] array2D = new int[rows, columns];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SortElOfRowsIn2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array2D.GetLength(1); k++)
            {
                if (array2D[i, j] < array2D[i, k])
                {
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[i, k];
                    array2D[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();

Console.Write("rows = ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("columns = ");
int columns = int.Parse(Console.ReadLine()!);

int[,] myArray = GetArray2D(rows, columns, -10, 10);
Console.WriteLine();
PrintArray(myArray);
SortElOfRowsIn2DArray(myArray);
Console.WriteLine();
PrintArray(myArray);