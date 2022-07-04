int[] keybord = new int[10];
Console.WriteLine("Введите числа массива:");
for (int i = 0; i < keybord.Length - 1; i++)
{
    Console.WriteLine($"Введите {i} элемент  массива:");
       keybord[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Массив :");
for (int i = 0; i < keybord.Length; i++)
{
    Console.WriteLine(keybord[i]);
}

Console.WriteLine("Введите еще одно значение :");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите место в массиве :");
int pos = Convert.ToInt32(Console.ReadLine());

for (int i = keybord.Length - 1; i > pos; i--)
{
    keybord[i] = keybord[i - 1];
}

keybord[pos] = number;

Console.WriteLine("Массив теперь:");
for (int i = 0; i < keybord.Length; i++)
{
    Console.WriteLine(keybord[i]);
}
