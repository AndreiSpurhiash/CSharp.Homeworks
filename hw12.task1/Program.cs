using hw12.task1;

Junior_Developer jun = new Junior_Developer();
jun.Enginer(Guid.NewGuid(), "Andrei", "Spurhiash",  new DateTime(1994,02,02), 0,
    "ASP.NET Core, Entity Framework, LINQ,Git, English language","c#, GIT", "gitHub/AndreiSpurhiash");

Middle_Developer middle = new Middle_Developer();
middle.Enginer(Guid.NewGuid(), "Victor", "Aryshev", new DateTime(1989, 01, 02), 2,
    "ASP.NET Core, Entity Framework, LINQ,Git, English language, SQL", "c#, GIT,ASP.NET Core", "gitHub/AndreiSpurhiash");

Senior_Developer senior = new Senior_Developer();
senior.Enginer(Guid.NewGuid(), "Artiom", "Zaycev", new DateTime(1988, 06, 15), 4,
    "ASP.NET Core, Entity Framework, LINQ,Git, English language, SQL,Unity", "c#, GIT,ASP.NET Core,LINQ,SQL", "gitHub/AndreiSpurhiash");

Team_Leader teamLead = new Team_Leader();
teamLead.Enginer(Guid.NewGuid(), "Victor", "Aryshev", new DateTime(1985, 07, 12), 7,
    "ASP.NET Core, Entity Framework, LINQ,Git, English language, SQL", "c#, GIT,ASP.NET Core", "gitHub/AndreiSpurhiash");
 
Architect architect = new Architect();
teamLead.Enginer(Guid.NewGuid(), "Olga", "Vorobej", new DateTime(1985, 09, 11), 9,
    "ASP.NET Core, Entity Framework, LINQ,Git, English language, SQL", "c#, GIT,ASP.NET Core", "gitHub/AndreiSpurhiash");

Object[] arr = new object[] {jun, middle, senior, teamLead, architect };

foreach (var item in arr)
{
    Console.WriteLine(item);
}