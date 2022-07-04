int number2 = 0;
int number4 = 0;
int sum = 0;
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

int sumTrue = number2 + number4;

for (; ; )
{
    Console.WriteLine("Введите сумму двух чисел :");
    string text3 = (Console.ReadLine());

    if (int.TryParse(text3, out int number5))
    {
        sum = number5;
        if (sum == sumTrue)
        {
            Console.WriteLine($"Правильно сумма = {sumTrue} ");
            break;
        }
        else
        {
            if (sum < sumTrue)
            {
                Console.WriteLine("Сумма должна быть больше! ");
            }
            else
            {
                Console.WriteLine("Сумма должна быть меньше! ");
            }
        }
    }
    else
    {
        Console.WriteLine("Введенный символ не является числом, введите число");
    }
}
