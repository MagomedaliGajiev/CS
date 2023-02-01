// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. ●456 -> 46 ●782 -> 72 ●918 -> 98

Console.Clear();

int number = new Random().Next(100, 1000);

int n1 = number / 100; // получаем первую цифру
int n3 = number % 10; // получаем третью цифру

int result = n1 * 10 + n3;

Console.WriteLine($"{number} => {result}");