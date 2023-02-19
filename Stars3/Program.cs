//  Написать программу для перевода римских чисел в десятичные арабские.
//  III -> 3
//  LVIII -> 58
//  MCMXCIV -> 1994

int TranslateRomanToArabic(string value)
{
    Dictionary<string, int> romanNumbers = new() {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000},
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
    };

    value = value.ToUpper();
    string token;
    int sum = 0;
    for (int i = 0; i < value.Length; i++)
    {
        if (!romanNumbers.ContainsKey(value[i].ToString()))
        {
            Console.WriteLine($"Неверный символ {value[i]}");
            return -1;
        }
        if (i < value.Length - 1 && romanNumbers.ContainsKey(value.Substring(i, 2)))
        {
            token = value.Substring(i, 2);
            ++i;
        }
        else if (i < value.Length - 1 && romanNumbers[value[i].ToString()] < romanNumbers[value[i + 1].ToString()])
        {
            Console.WriteLine($"Неверное правило {value.Substring(i, 2)}");
            return -1;
        }
        // Валидация ввода, цифры I, X, C, M не могут повторяться более 3 раз.
        else if (i < value.Length - 3 && value.Substring(i, 4) == "IIII"
                || i < value.Length - 3 && value.Substring(i, 4) == "XXXX"
                || i < value.Length - 3 && value.Substring(i, 4) == "CCCC"
                || i < value.Length - 3 && value.Substring(i, 4) == "MMMM"
        )
        {
            Console.WriteLine($"Неверное правило, цифры I, X, C, M не могут повторяться более 3 раз");
            return -1;
        }
        // Валидация ввода, цифры V, L, D не могут повторяться.
        else if (i < value.Length - 1 && value.Substring(i, 2) == "VV"
                || i < value.Length - 1 && value.Substring(i, 2) == "LL"
                || i < value.Length - 1 && value.Substring(i, 2) == "DD"
        )
        {
            Console.WriteLine($"Неверное правило, цифры V, L, D не могут повторяться");
            return -1;
        }
        else
        {
            token = value.Substring(i, 1);
        }

        sum += romanNumbers[token];
    }
    return sum;
}

Console.Clear();

while (true)
{
    Console.Write("Введите римское число или введите exit для выхода: ");
    string romanNumber = Console.ReadLine()!;
    if (romanNumber == "exit") break;
    Console.WriteLine(TranslateRomanToArabic(romanNumber));
}

