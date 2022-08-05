using Patterns.Singleton;

var singleton = Singleton.GetInstance("Hello World!");
var singleton2 = Singleton.GetInstance("Hello space!");
Console.WriteLine(singleton2.Data);
Console.ReadLine();
