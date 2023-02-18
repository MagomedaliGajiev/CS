// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран. m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] GetArray(int m, int n)
{
    int[,] array = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
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

Console.Clear();

Console.Write("Enter a dimension of the array separated by commas: ");
int[] dimension = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int m = dimension[0], n = dimension[1];
int[,] myArray = GetArray(m, n);
Console.WriteLine();
PrintArray(myArray);