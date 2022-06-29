int number2 = 0;
int number4 = 0;
    for (; ; )
    {
        Console.WriteLine("Введите число 1 :");
        string text1 = (Console.ReadLine());
        if (int.TryParse(text1, out int number1))
        {
            number2 = number1;
            break;
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом, введите число");
        }

    }

    for (; ; )
    {
        Console.WriteLine("Введите число 2 :");
        string text2 = (Console.ReadLine());

        if (int.TryParse(text2, out int number3))
        {
            number4 = number3;
            break;
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом, введите число");
        }
    }
    int sum = number2 + number4;
Console.WriteLine($"Сумма числа {number2} и числа {number4} = {sum}");
