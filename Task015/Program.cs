// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите цифру, обозначающую день недели: ");
 int numberDayOfWeek = int.Parse(Console.ReadLine()!);

 while (numberDayOfWeek < 1 || numberDayOfWeek > 7)
 {
    Console.Write("Введите цифру от 1 до 7!: ");
    numberDayOfWeek = int.Parse(Console.ReadLine()!);
 }

 if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
 {
    Console.WriteLine("да");
 }
 else
 {
    Console.WriteLine("нет");
 }