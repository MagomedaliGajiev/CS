// Задача №21. Работа в группах Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.
//● A (3,6); B (2,1) -> 5,09 
//● A (7,-5); B (1,-1) -> 7,21
// AB = √((xb - xa)^2 + (yb - ya)^2).

Console.Clear();

Console.Write("Введите координаты точки Xa: ");
int Xa = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки Ya: ");
int Ya = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки Xb: ");
int Xb = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки Yb: ");
int Yb = int.Parse(Console.ReadLine()!);

double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2);
double len = Math.Sqrt(x);
Console.WriteLine($"{len:f2}");