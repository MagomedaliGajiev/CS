// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] GettArray(string s)
{
    int[] arr = Array.ConvertAll(s.Split(','), Convert.ToInt32);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.Write("Введите числа через запятую: ");

string numbers = Console.ReadLine()!;

int[] collection = GettArray(numbers);

PrintArray(collection);
