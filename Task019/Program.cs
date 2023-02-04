// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

while (number < 10000 || number > 99999)    // Проверяем ввели ли пятизначное число, если не ввели вводим заново
{
    Console.Write("Введите пятизначное число!: ");
    number = int.Parse(Console.ReadLine()!);
}

int left = number / 1000;  // получаем первые две цифры
int right = number % 100;  // получаем последние две цифры

bool isPalindrom = left / 10 == right % 10 && left % 10 == right / 10;  // проверяем является ли введенное число палиндромом

if (isPalindrom)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}