// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Введите координаты точки X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
{
    Console.WriteLine("The first quarter");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("The second quarter");
}
else if (X < 0 & Y < 0)
{
    Console.WriteLine("The third quarter");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("The fourth quarter");
}