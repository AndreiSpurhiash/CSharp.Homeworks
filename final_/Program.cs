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
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.Security.Cryptography.X509Certificates;


internal class Program
{
    private static async Task Main(string[] args)
    {
        

        Console.WriteLine("Здравствуйте Вас приветствует сервис по заказу суши");
        Console.WriteLine();

        Console.WriteLine("Как вас зовут?");
        Console.WriteLine();
        var client2 = new Client();

    start:
        for (; ; )
        {
            Console.WriteLine("Укажите имя :");
            Console.WriteLine();
            client2._NameClient = Console.ReadLine();

            ValidationContext context = new ValidationContext(client2)
            {
                MemberName = nameof(client2._NameClient)
            };
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(client2._NameClient, context, results))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                    goto start;
                }
            }
            else
                break;

        }
        Console.WriteLine();

    start1:
        for (; ; )
        {
            Console.WriteLine("Укажите номер телефона :");
            Console.WriteLine();
            client2._NumberPhone = Console.ReadLine();

            ValidationContext context = new ValidationContext(client2)
            {
                MemberName = nameof(client2._NumberPhone)
            };
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(client2._NumberPhone, context, results))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                    goto start1;
                }
            }
            else
                break;
        }
        Console.WriteLine();

    start2:
        for (; ; )
        {
            Console.WriteLine("Укажите Адрес доставки :");
            Console.WriteLine();
            client2._AdresClient = Console.ReadLine();

            ValidationContext context = new ValidationContext(client2)
            {
                MemberName = nameof(client2._AdresClient)
            };
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(client2._AdresClient, context, results))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                    goto start2;
                }
            }
            else
                break;
        }
        Console.WriteLine();

    start3:
        for (; ; )
        {
            Console.WriteLine("Укажите Адрес электронной почты :");
            Console.WriteLine();
            client2._MailClient = Console.ReadLine();

            ValidationContext context = new ValidationContext(client2)
            {
                MemberName = nameof(client2._MailClient)
            };
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(client2._MailClient, context, results))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                    goto start3;
                }
            }
            else
                break;
        }
        Console.WriteLine();



        SushiRepository sushiRepository1 = new SushiRepository();
        SushiService sushiService1 = new SushiService(sushiRepository1);


        

        var container = BuildContainer();
        var sushiRepository = container.Resolve<BaseRepository<Sushi>>();
        var clientRepository = container.Resolve<BaseRepository<Client>>();
        var orderRepository = container.Resolve<BaseRepository<Order>>();
        //var clientRepository = container.Resolve<IClientRepository>();
        //var orderRepository = container.Resolve<IOrderRepository>();

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SushiRepository>().As<BaseRepository<Sushi>>();
            builder.RegisterType<SushiService>().As<ISushiService>();
            builder.RegisterType<ClientRepository>().As<BaseRepository<Client>>();
            builder.RegisterType<OrderRepository>().As<BaseRepository<Order>>();
            return builder.Build();
        }

        clientRepository.Create(client2);
        clientRepository.Save();

        Order order = new Order(10.2M);
        order.ClientGuid = client2.Guid;
        orderRepository.Create(order);
        orderRepository.Save();

        //var list = await clientRepository.GetListAsync().ConfigureAwait(false);



        Console.WriteLine($"Добрый День {client2._NameClient}. Команда Sushi House работает на рынке доставки суши, роллов и других " +
            $"блюд японской кухни уже более 6 лет, и все эти годы главным для нас является любовь и признание наших Гостей.");
        Console.WriteLine();

        Console.WriteLine($"{client2._NameClient} Вы готовы приступить к заказу ???");
        Console.WriteLine();

        Console.WriteLine($"Нажмите кнопку для продолжения");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine($"Отлично {client2._NameClient} тогда сейчас я вам покажу наше меню");
        Console.WriteLine();

        Console.WriteLine($"Нажмите кнопку для продолжения");
        Console.WriteLine();
        Console.ReadKey();

        var sushies = await sushiService1.GetSushiAsync();
       

        Console.WriteLine($"Номер товара\t\t{"Название",-38}{"Стоимость",-50}Описание");
        Console.WriteLine();
        Console.WriteLine();


        foreach (var item in sushies.Data.OrderBy(x => x._Number))
        {
            Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine($" {client2._NameClient} укажите номер товара котрый Вы хотите добавить в карзину");
        Console.WriteLine();

        Console.WriteLine("Номер товара :");
        var numberOrder = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Количество:");
        Console.WriteLine();


        //switch (numberOrder)
        //{
        //    case 1: sushies.Add


        //}



    }
}