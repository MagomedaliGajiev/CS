// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}



void PrintArrayHourHand(int[,] inArray)
{
    int m = inArray.GetLength(0);
    int n = inArray.GetLength(1);
    bool[,] visited = new bool[m, n]; // задаем булевый массив для проверки вывода элментов нашего текущего массива
    bool isEnd = false; // флаг для выхода из главного цикла
    int x = m - 1, y = 0; // начинаем ввывод нашего массива с левого нижнего угла

    while (!isEnd) // вывод массива по часовай стрелки до посленего элемента
    {
        isEnd = true;
        while (y < n - 1 && !visited[x, y + 1]) // движение вправо
        {
            isEnd = false;
            Console.Write($"{inArray[x, y]} ");
            visited[x, y] = true;
            ++y;
        }
        while (x > 0 && !visited[x - 1, y]) // движение вверх
        {
            isEnd = false;
            Console.Write($"{inArray[x, y]} ");
            visited[x, y] = true;
            --x;
        }
        while (y > 0 && !visited[x, y - 1])  // движение влево
        {
            isEnd = false;
            Console.Write($"{inArray[x, y]} ");
            visited[x, y] = true;
            --y;
        }
        while (x < m - 1 && !visited[x + 1, y])  // движение вниз
        {
            isEnd = false;
            Console.Write($"{inArray[x, y]} ");
            visited[x, y] = true;
            ++x;
        }
    }
    Console.Write($"{inArray[x, y]} "); // вывод последненго элемента массива
}

Console.Clear();

Console.Write("Введите размерность массива через пробел: ");
int[] dimension = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int row = dimension[0];
int col = dimension[1];

Console.WriteLine();
int[,] myArray = GetArray(row, col, 1, 9);
PrintArray(myArray);
Console.WriteLine();
PrintArrayHourHand(myArray);