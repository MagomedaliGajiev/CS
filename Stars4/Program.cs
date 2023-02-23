// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает
// целую часть квадратного корня от введенного числа. 4 -> 2 28 -> 5

int Sqrt(int number)
{
    int left = 0;
    int right = number;

    while (right > left)
    {
    //    System.Console.WriteLine($"({left}, {right})");
        int m = (left + right) / 2;
        if (m * m < number)
        {
            left = m;
        }
        else if ( m * m > number)
        {
            right = m;
        }
        else
        {
            return m;
        }

        if (right - left == 1){ 
            return right * right <= number ? right : left;
        }
    }
    return left;
}

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sqrt(num));