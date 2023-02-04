// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
// вводим координаты точки A
Console.Write("Введите координаты Xa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Za: ");
int Za = int.Parse(Console.ReadLine()!);

// вводим координаты точки B
Console.Write("Введите координаты Xb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Yb: ");
int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Zb: ");
int Zb = int.Parse(Console.ReadLine()!);

// AB = √((xb - xa)^2 + (yb - ya)^2 + (zb - za)^2) - формула нахождения растояния между точками A и B в трехмерном помтранстве 
double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Za - Zb, 2);
double len = Math.Sqrt(x);  // находим растояние между точками A и B

Console.WriteLine($"{len:f2}");