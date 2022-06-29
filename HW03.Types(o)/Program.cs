// Parse

int a = int.Parse("15");
double b = double.Parse("23,56");
decimal c = decimal.Parse("12,45");
byte d = byte.Parse("4");
char e = char.Parse("H");
Console.WriteLine($"int={a}  double={b}  decimal={c}  byte={d} char={e}");

// TryParse

bool result;
Char value;

result = Char.TryParse("A", out value);
Console.WriteLine(result);

result = Char.TryParse("Za", out value);
Console.WriteLine(result);


string inputString = "23";
if (int.TryParse(inputString, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("inputString is invalid");
}


