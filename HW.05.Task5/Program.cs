Console.WriteLine("Введите число : ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{ 
    for (int j = height; j > i ; j--)
    {
        Console.Write($"{height} ");
    }
    Console.WriteLine();
}
