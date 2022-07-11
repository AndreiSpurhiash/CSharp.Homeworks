// Сравнение строк не найдено

string str = "Hello guys";
string str2 = "47";
string str3 = "Hello GUYS";
string str4 = "43";
string str5 = "54";
string str6 = "47";


bool results = str.Equals(str3);
Console.WriteLine(results);
Console.WriteLine(str4.Equals(str5));

// через класс
Console.WriteLine(string.Equals(str4,str5));
Console.WriteLine(string.Equals(str2, str6));

// Сравнение без учета регистра
Console.WriteLine(str.Equals(str3, StringComparison.OrdinalIgnoreCase));
// с учетом культуры
Console.WriteLine(str2.Equals(str3, StringComparison.InvariantCulture));

