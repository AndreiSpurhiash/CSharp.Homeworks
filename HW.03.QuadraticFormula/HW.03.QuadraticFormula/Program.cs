// Корни квадратного уровнения

Console.WriteLine("Введите значение первого коэфициента  'a'");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение второго коэфициента  'b'");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение свободного члена  'c'");
double c = Convert.ToDouble(Console.ReadLine());

double discriminat = Convert.ToDouble((Math.Pow(b, 2)) - (4 * a * c));
Console.WriteLine(discriminat);

double x1 = -b + Math.Sqrt(discriminat) / (2 * a);
double x2 = -b - Math.Sqrt(discriminat) / (2 * a);

Console.WriteLine($"Первый корень уровнения = {x1}");
Console.WriteLine($"Первый корень уровнения = {x2}");
