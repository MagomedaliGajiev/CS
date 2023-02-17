// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] collection)
{
    Console.Write($"[{String.Join(" ", collection)}]");
}

void GetReveredArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp; 
    }
}

Console.Clear();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] myArray = GetArray(size, 1, 9);
PrintArray(myArray);
GetReveredArray(myArray);
Console.Write(" -> ");
PrintArray(myArray);