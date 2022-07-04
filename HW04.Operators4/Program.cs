int number2 = 0;
int number4 = 0;
int sumTrue;
int sum; 
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

for (; ; )
{
    Console.WriteLine("Если вы хотите сложить числа нажмите +, если отнять - :");
    string text3 = (Console.ReadLine());

    char.TryParse(text3, out char simvol);

    switch (simvol)
    {

        case '+':
            sumTrue = number2 + number4;
            goto next;
        case '-':
            sumTrue = number2 - number4;
            goto next;
        default:
            Console.WriteLine("Введенный не правильный символ попробуйте сново");
            break;
    }
}

next:
for (; ; )
{
    Console.WriteLine("Введите сумму либо разницу двух чисел :");
    string text4 = (Console.ReadLine());

    if (int.TryParse(text4, out int number5))
    {
        sum = number5;
        if (sum == sumTrue)
        {
            Console.WriteLine($"Правильно ответ = {sumTrue} ");
            break;
        }
        else
        {
            if (sum < sumTrue)
            {
                Console.WriteLine("Должно быть больше! ");
            }
            else
            {
                Console.WriteLine("Должно быть меньше! ");
            }
        }
    }
    else
    {
        Console.WriteLine("Введенный символ не является числом, введите число");
    }
}
