// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

string GetAverageOfColOfArray(int[,] inArray2D)
{
    string result = "Среднее арифметическое каждого столбца: ";
    double sum;
    double average;
    for (int i = 0; i < inArray2D.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray2D.GetLength(0); j++)
        {
            sum += inArray2D[j, i];
        }
        average = sum / inArray2D.GetLength(0);
        result += $"{average:f1}";
        if (i != inArray2D.GetLength(1) - 1) result += "; ";
        else result += ".";
    }
    return result;
}

Console.Clear();

Console.Write("Введите количество строк в двумерном массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(rows, columns, -10, 10);
PrintArray(array2D);
Console.WriteLine(GetAverageOfColOfArray(array2D));