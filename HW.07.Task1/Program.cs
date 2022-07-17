using System.Text;

StringBuilder str = new StringBuilder();
str.Append("1a!2.3!!..4.!.? 6 7!.. ?");
Console.WriteLine(str);

str.Remove(2, 1);
str.Remove(5, 2);
str.Remove(9, 1);
Console.WriteLine(str);

str.Replace(' ', '_', 11, 8);
Console.WriteLine(str);