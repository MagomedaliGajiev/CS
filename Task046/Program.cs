// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//  m = 3, n = 4.
// 1 4 8 19 
// 5 -2 33 -2 
// 77 3 8 1

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

Console.Clear();

Console.Write("Enter a dimension of the array separated by commas: ");
int[] dimension = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int m = dimension[0], n = dimension[1];
int[,] myArray = GetArray(m, n, -10, 10);
Console.WriteLine();
PrintArray(myArray);