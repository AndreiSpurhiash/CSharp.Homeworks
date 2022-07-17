Console.WriteLine("Введите стихотворение :");
string text = Console.ReadLine();
string bukva = text.Replace("о", "а");
string[] str = bukva.Split(';');

foreach (var simvol in str)
{
    Console.WriteLine($"{simvol}");
}