// Задача №18. Работа в группах Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
//  точек в этой четверти (x и y).

Console.Clear();

Console.Write("Please enter the number of the quarter: ");
int Q = int.Parse(Console.ReadLine()!);

switch (Q)
{
    case 1:
        Console.WriteLine("X > 0, Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0, Y > 0");
        break;
    case 3:
        System.Console.WriteLine("X < 0, Y < 0");
        break;
    case 4:
        System.Console.WriteLine("X > 0, Y < 0 ");
        break;
    default:
        System.Console.WriteLine("Please enter number from 1 to 4!");
        break;
}