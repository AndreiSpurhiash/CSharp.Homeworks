using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using Final_project.DAL;
using Final_project.DAL.Repositories;
using Final_project.Domain.Entity;
using Final_project.Service.Implementations;
using Final_project.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Autofac;
using Final_project;
using Final_project.DAL.Interfaces;

SushiRepository sushiRepository = new SushiRepository();
SushiService sushiService = new SushiService(sushiRepository);



static IContainer BuildContainer()
{
    var builder = new ContainerBuilder();
    builder.RegisterType<SushiRepository>().As<ISushiRepository>();
    builder.RegisterType<SushiService>().As<ISushiService>();
    return builder.Build();
}

Console.WriteLine("Здравствуйте Вас приветствует сервис по заказу суши");
Console.WriteLine();

Console.WriteLine("Как вас зовут");
Console.WriteLine();

Console.WriteLine("Укажите имя :");
Console.WriteLine();

string NameClient = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Укажите номер телефона :");
Console.WriteLine();
 string PhoneClient = Console.ReadLine();

Console.WriteLine("Укажите Адрес доставки :");
Console.WriteLine();
string AdresClient = Console.ReadLine();

Console.WriteLine("Укажите электронную почту :");
Console.WriteLine();
string EmailClient = Console.ReadLine();

Client client = new Client(NameClient, PhoneClient, AdresClient, EmailClient);

Console.WriteLine($"Добрый День {client._NameClient}. Команда Sushi House работает на рынке доставки суши, роллов и других " +
    $"блюд японской кухни уже более 6 лет, и все эти годы главным для нас является любовь и признание наших Гостей.");
Console.WriteLine();

Console.WriteLine($"{client._NameClient} Вы готовы приступить к заказу ???");
Console.WriteLine();

Console.WriteLine($"Нажмите кнопку для продолжения");
Console.WriteLine();

Console.ReadKey();

Console.WriteLine($"Отлично {client._NameClient} тогда сейчас я вам покажу наше меню");
Console.WriteLine();


Console.WriteLine($"Нажмите кнопку для продолжения");
Console.WriteLine();
Console.ReadKey();

var sushies = await sushiService.GetSushiAsync();

Console.WriteLine($"Номер товара\t\t{"Название",-38}{"Стоимость",-50}Описание");
Console.WriteLine();
Console.WriteLine();


foreach (var item in sushies.Data.OrderBy(x=>x._Number))
{
    Console.WriteLine(item.ToString());
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine($" {client._NameClient} укажите номер товара котрый Вы хотите добавить в карзину");
Console.WriteLine();

Console.WriteLine("Номер товара :");
Console.WriteLine();

Console.WriteLine("Количество:");
Console.WriteLine();



