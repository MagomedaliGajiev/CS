// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите целые числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32); 

int max = array[0];
int index = 1; // начинаем со 2-го элемента массива

while(index < array.Length)
{
    if(array[index] > max) max = array[index];
    index++;
}

Console.Write($"Максималное число равно: {max}");