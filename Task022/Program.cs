// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

//  • 5 -> 1, 4, 9, 16, 25.
//  • 2 -> 1,4

Console.Clear();

Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine()!);
int index = 1;

while (index <= N)
{

    // Console.Write($"{index * index} ");
    // index++;

    Console.Write(Math.Pow(index, 2));
    if (index != N)
    {
        Console.Write(", ");
    }
    index++;
}
Console.WriteLine(".");