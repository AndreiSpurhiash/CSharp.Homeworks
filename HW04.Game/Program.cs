
start:
for (; ; )
{
    Console.WriteLine("Куда нужно переместить фигуру? Если вверх нажмите 'W', если вниз 'S', " +
    "если влево 'A', если вправо 'D'. \nВ случае отсутствия необходимости перемещения нажмите 'H'");
    string text = (Console.ReadLine());
    char.TryParse(text, out char bukva);

    switch (bukva)
    {
        case 'w':
        case 'W':
            Console.WriteLine("Объект перемещается Вверх");
            Console.WriteLine("Если хотите изменить направление нажмите 1. " +
                "\nВ случае отсутствия необходимости перемещения нажмите 2 ");
            string text4 = (Console.ReadLine());
            int.TryParse(text4, out int cifra2);
            switch (cifra2)
            {
                case 1:
                    goto start;

                case 2:
                    Console.WriteLine("Объект неподвижен, если хотите изменить направление нажмите 1");
                    string text5 = (Console.ReadLine());
                    int.TryParse(text5, out int cifra3);

                    switch (cifra3)
                    {
                        case 1:
                            goto start;

                        default:
                            Console.WriteLine("Введенный не правильный символ попробуйте сново");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Введенный не правильный символ попробуйте сново");
                    break;
            }
            break;
        case 's':
        case 'S':
            Console.WriteLine("Объект перемещается Вниз");
            Console.WriteLine("Если хотите изменить направление нажмите 1. " +
                "\nВ случае отсутствия необходимости перемещения нажмите 2 ");
            string text8 = (Console.ReadLine());
            int.TryParse(text8, out int cifra6);
            switch (cifra6)
            {
                case 1:
                    goto start;

                case 2:
                    Console.WriteLine("Объект неподвижен, если хотите изменить направление нажмите 1");
                    string text9 = (Console.ReadLine());
                    int.TryParse(text9, out int cifra7);

                    switch (cifra7)
                    {
                        case 1:
                            goto start;

                        default:
                            Console.WriteLine("Введенный не правильный символ попробуйте сново");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Введенный не правильный символ попробуйте сново");
                    break;
            }
            break;
        case 'a':
        case 'A':
            Console.WriteLine("Объект перемещается Влево");
            Console.WriteLine("Если хотите изменить направление нажмите 1. " +
                "\nВ случае отсутствия необходимости перемещения нажмите 2 ");
            string text12 = (Console.ReadLine());
            int.TryParse(text12, out int cifra10);
            switch (cifra10)
            {
                case 1:
                    goto start;

                case 2:
                    Console.WriteLine("Объект неподвижен, если хотите изменить направление нажмите 1");
                    string text13 = (Console.ReadLine());
                    int.TryParse(text13, out int cifra11);

                    switch (cifra11)
                    {
                        case 1:
                            goto start;

                        default:
                            Console.WriteLine("Введенный не правильный символ попробуйте сново");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Введенный не правильный символ попробуйте сново");
                    break;
            }
            break;
        case 'D':
        case 'd':
            Console.WriteLine("Объект перемещается Вправо");
            Console.WriteLine("Если хотите изменить направление нажмите 1. " +
                "\nВ случае отсутствия необходимости перемещения нажмите 2 ");
            string text16 = (Console.ReadLine());
            int.TryParse(text16, out int cifra14);
            switch (cifra14)
            {
                case 1:
                    goto start;

                case 2:
                    Console.WriteLine("Объект неподвижен, если хотите изменить направление нажмите 1");
                    string text17 = (Console.ReadLine());
                    int.TryParse(text17, out int cifra15);

                    switch (cifra15)
                    {
                        case 1:
                            goto start;

                        default:
                            Console.WriteLine("Введенный не правильный символ попробуйте сново");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Введенный не правильный символ попробуйте сново");
                    break;
            }
            break;

        default:
            Console.WriteLine("Введенный не правильный символ попробуйте сново");
            break;

    }
}




