using System.Globalization;
decimal money = 1;
DateTime date = DateTime.Now;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("be-By");
Console.WriteLine($"Date and time format for Belarus is \"{date}\". The national currency is \'{money:C}\'.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pl-PL");
Console.WriteLine($"Date and time format for Poland is \"{date}\". The national currency is \'{money:C}\'.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"Date and time format for USA is \"{date}\". The national currency is \'{money:C}\'.");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-CA");
string format =string.Format("Date and time format for Canada is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(format);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");
string formatFrance = string.Format("Date and time format for France is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(formatFrance);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("it-IT");
string formatItali = string.Format("Date and time format for Itali is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(formatItali);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("nl-NL");
string formaNetherland = string.Format("Date and time format for Netherland is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(formaNetherland);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ru-RU");
string formaRusian = string.Format("Date and time format for Russian is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(formaRusian);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("zh-hans-CH");
string formaChina = string.Format("Date and time format for China is \"{0}\". The national currency is \'{1:C}\'.", date, money);
Console.WriteLine(formaChina); 