Console.WriteLine("Введите год рождения");
int year_birthday = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения");
int month_birthday = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите нынешний год ");
int year_now = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нынешний месяц");
int month_now = Convert.ToInt32(Console.ReadLine());

int year_old;

if (month_now < month_birthday)
{
    year_old = (year_now - year_birthday) - 1;
}
else year_old = year_now - year_birthday;

Console.WriteLine("Ваш Возраст = " + year_old);

Console.ReadLine();
