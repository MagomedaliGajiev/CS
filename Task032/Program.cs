// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] collection = new int[size];

    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(minValue, maxValue + 1);

    }
    return collection;
}

void SigChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] myArray = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", myArray));
SigChange(myArray);
Console.WriteLine(String.Join(", ", myArray));