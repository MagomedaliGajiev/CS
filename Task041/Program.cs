// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int CountEvenNumbers(string value)
{
    int count = 0;
    string[] ss = value.Split(',');
    int len = ss.Length;
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = int.Parse(ss[i]);
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine()!;
int result = CountEvenNumbers(numbers);
Console.WriteLine($"[{numbers}] -> {result}");