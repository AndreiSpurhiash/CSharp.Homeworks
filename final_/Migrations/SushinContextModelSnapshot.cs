﻿// <auto-generated />
using System;
using Final_project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Final_project.Migrations
{
    [DbContext(typeof(SushinContext))]
    partial class SushinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Final_project.Domain.Entity.Client", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<string>("_AdresClient")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text")
                        .HasColumnName("Adres");

                    b.Property<string>("_MailClient")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("_NameClient")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("_NumberPhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("text")
                        .HasColumnName("Phone");

                    b.HasKey("Guid")
                        .HasName("Id1");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Order", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<Guid>("ClientGuid")
                        .HasColumnType("uuid")
                        .HasColumnName("ClientGuid");

                    b.Property<DateTime>("_DateOrder")
                        .HasColumnType("timestamp")
                        .HasColumnName("DateOrder");

                    b.Property<decimal>("_Price")
                        .HasColumnType("numeric")
                        .HasColumnName("Price");

                    b.HasKey("Guid")
                        .HasName("Id2");

                    b.HasIndex("ClientGuid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Sushi", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<Guid>("OrderGuid")
                        .HasColumnType("uuid");

                    b.Property<decimal>("_Coast")
                        .HasColumnType("numeric(38,17)")
                        .HasColumnName("Coast");

                    b.Property<string>("_Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<string>("_Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<int>("_Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.HasKey("Guid")
                        .HasName("Key");

                    b.HasIndex("OrderGuid");

                    b.ToTable("Sushi");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("aa938e6c-cfa3-4bba-a948-436e8cacbc1e"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 1.2m,
                            _Description = "Ломтики кремообразного авокадо отлично сочетаются со свежесмолотым черным перцем",
                            _Name = "Суши с авокадо(Авокадо Нигири)",
                            _Number = 1
                        },
                        new
                        {
                            Guid = new Guid("b39e3832-022b-467a-927f-7965f1df9f80"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 1.5m,
                            _Description = "Гребешок морской, рис, васаби",
                            _Name = "Суши с гребешком (Хотатэгай Нигири)",
                            _Number = 2
                        },
                        new
                        {
                            Guid = new Guid("d228a9d2-fc82-4933-80bb-16b92ca2a5b2"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 2.5m,
                            _Description = "Лосось копченый, рис, васаби",
                            _Name = "Суши с копченым лососем (Сяке гурме Нигири)",
                            _Number = 3
                        },
                        new
                        {
                            Guid = new Guid("54c239de-445c-482b-9239-1bfacaca1139"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.5m,
                            _Description = "Суши нигири с желтохвостой лакедрой, богатой жирными кислотами и полезными микроэлементами",
                            _Name = "Суши с лакедрой желтохвостой (Хамачи Нигири)",
                            _Number = 4
                        },
                        new
                        {
                            Guid = new Guid("90340c09-db6e-4dd4-bfc2-07db241a11e3"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 1.9m,
                            _Description = "Ролл с лососем, сливочным сыром и огурцом в оранжевой икре капеллана Масаго",
                            _Name = "Суши с лососем (Сяке Нигири)",
                            _Number = 5
                        },
                        new
                        {
                            Guid = new Guid("4653a585-b318-417f-a37d-254cd00f35d5"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.6m,
                            _Description = "Лепные суши с моллюском хоккигаем",
                            _Name = "Суши с моллюском Хоккигай (Хоккигай Нигири)",
                            _Number = 6
                        },
                        new
                        {
                            Guid = new Guid("1f9c7537-5cb6-4da2-a8ae-45c9057291e0"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 2.1m,
                            _Description = "Острые суши гункан с морским окунем, приправленные специальным острым соусом спайси",
                            _Name = "Суши с окунем (Идзуми тай Нигири)",
                            _Number = 7
                        },
                        new
                        {
                            Guid = new Guid("1db147a5-b51c-4e53-aac5-7f6010540a72"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 2.2m,
                            _Description = "Суши нигири со специальным японским слоистым омлетом тамаго, приправленным соусом унаги",
                            _Name = "Суши с омлетом (Тамаго Нигири)",
                            _Number = 8
                        },
                        new
                        {
                            Guid = new Guid("c96d6436-be1e-46ea-a048-7d5c2175b675"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.9m,
                            _Description = "Острые суши гункан с мясом осьминога, приправленным специальным острым соусом спайси",
                            _Name = "Суши с осьминогом (Тако Нигири)",
                            _Number = 9
                        },
                        new
                        {
                            Guid = new Guid("ae3442e3-8410-4928-a962-3d7edd20b01c"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3m,
                            _Description = "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом",
                            _Name = "Суши с тигровой креветкой (Эби Нигири)",
                            _Number = 10
                        },
                        new
                        {
                            Guid = new Guid("85a3a000-6e43-4205-b357-e98dcd556de1"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3m,
                            _Description = "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом",
                            _Name = "Суши с тигровой креветкой (Эби Нигири)",
                            _Number = 11
                        },
                        new
                        {
                            Guid = new Guid("8e738411-e60a-4567-a8f3-e12ee4a32f23"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.1m,
                            _Description = "Оригинальный ролл с тунцом, японским омлетом, помидором и майонезом в оранжевой икре",
                            _Name = "Суши с тунцом (Магуро Нигири)",
                            _Number = 12
                        },
                        new
                        {
                            Guid = new Guid("a875048e-3eb4-45da-9f47-303981cf4294"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.9m,
                            _Description = "Суши гункан с нарезанным мясом крупной креветки, приправленным специальным сладким соусом",
                            _Name = "Суши со сладкой креветкой (Ама Эби Нигири)",
                            _Number = 13
                        },
                        new
                        {
                            Guid = new Guid("774998f1-a816-49f2-ba33-f8720abecce4"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.3m,
                            _Description = "Суши гункан, заполненные икрой тобико летучей рыбы",
                            _Name = "Суши с икрой летучей рыбы в огурце",
                            _Number = 14
                        },
                        new
                        {
                            Guid = new Guid("224556b3-27fe-4972-a70a-2744a7f32cce"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.2m,
                            _Description = "Запеченые острые суши с мидиями в огурце, под икорно сырным острым соусом",
                            _Name = "Суши с мидиями в огурце",
                            _Number = 15
                        },
                        new
                        {
                            Guid = new Guid("fdb238d1-8eb1-4f83-8ece-0b34e0291819"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.5m,
                            _Description = "Суши гункан, заполненные салатом из морских водорослей вакамэ, приправленным орехово-кунжутным соусом",
                            _Name = "Суши с салатными креветками в огурце",
                            _Number = 16
                        },
                        new
                        {
                            Guid = new Guid("3cd8e391-4a85-4226-94f4-f5f93fea8d2c"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 3.6m,
                            _Description = "Любимый ролл японского водяного Каппа - ролл с огурцом цыпленком и кунжутом",
                            _Name = "Суши с цыпленком в огурце",
                            _Number = 17
                        },
                        new
                        {
                            Guid = new Guid("a46b4450-794f-4d55-9645-6a9e55cb4e60"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4m,
                            _Description = "Гребешок, огурец, тобико, творожный сыр",
                            _Name = "Ролл Урамаки Острый гребешок",
                            _Number = 18
                        },
                        new
                        {
                            Guid = new Guid("869352a2-e387-4a06-bc34-518e814a5733"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.9m,
                            _Description = "Ролл с кальмаром, японским омлетом, икрой летучей рыбы и стружкой тунца",
                            _Name = "Ролл Урамаки Острый кальмар",
                            _Number = 19
                        },
                        new
                        {
                            Guid = new Guid("b525698f-1e9e-4376-9905-ff0192659b2b"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.2m,
                            _Description = "Рис, нори, угорь, огурец, лосось, кимчи соус, лук зелёный",
                            _Name = "Ролл Урамаки Острый копченый угорь",
                            _Number = 20
                        },
                        new
                        {
                            Guid = new Guid("cc56f405-097d-45fb-831f-0704ffadb4f6"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.3m,
                            _Description = "Теплый ролл с окунем, огурцом и соусом спайс",
                            _Name = "Ролл Урамаки Острый морской окунь",
                            _Number = 21
                        },
                        new
                        {
                            Guid = new Guid("5bc15174-9c9a-4577-a594-90a1f482991f"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.4m,
                            _Description = "Ролл с окунем, японским омлетом, икрой летучей рыбы и стружкой тунца",
                            _Name = "Ролл Урамаки Острый тунец",
                            _Number = 22
                        },
                        new
                        {
                            Guid = new Guid("12878923-7eea-47ac-a90e-845fd89f5ee3"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 4.5m,
                            _Description = "Оригинальный ролл, необычное сочетание копченой курицы и бекона со свежими овощами и спайси-соусом",
                            _Name = "Ролл Урамаки Острый цыпленок",
                            _Number = 23
                        },
                        new
                        {
                            Guid = new Guid("aabf5e03-baef-4c0c-be76-475e86f3ab0b"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.9m,
                            _Description = "Аппетитный запеченный ролл с салатным крабом, огурцом и сыром сливочным, под шапкой и соуса спайс",
                            _Name = "Запеченный ролл Калифорния с крабом",
                            _Number = 24
                        },
                        new
                        {
                            Guid = new Guid("4fcebf79-e8db-4845-9e0c-cd39e3833812"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.9m,
                            _Description = "Аппетитный запеченный ролл с нежным лососем, огурцом и сыром сливочным, под шапкой и майонеза",
                            _Name = "Запеченный ролл Калифорния с лососем",
                            _Number = 25
                        },
                        new
                        {
                            Guid = new Guid("3b7add4b-95b1-4f66-b9dd-af891b63f27c"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.2m,
                            _Description = "Аппетитный запечённый ролл с копчёным угрём, японским омлетом, огурцом, мидиями, майонезом, икрой капеллана и сыром Пармезан",
                            _Name = "Запеченный ролл с копченым угрем и омлетом",
                            _Number = 26
                        },
                        new
                        {
                            Guid = new Guid("eda10871-7683-451f-9722-38c17056243d"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.3m,
                            _Description = "Рис, нори, лосось, гребешок, крем-сыр, авокадо, спайси соус, унаги соус",
                            _Name = "Запеченный ролл с острым гребешком",
                            _Number = 27
                        },
                        new
                        {
                            Guid = new Guid("e67b7118-3f55-4e56-904f-46b78a6d1c32"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.4m,
                            _Description = "Кальмар, фирменная сырная шапка, соус Унаги, кунжут, рис, нори",
                            _Name = "Запеченный ролл с острым кальмаром",
                            _Number = 28
                        },
                        new
                        {
                            Guid = new Guid("8159f80e-09f4-4074-9a1c-db6cbe2ec296"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.5m,
                            _Description = "Жгучий запеченный ролл с омлетом и творожным сыром под шапочкой из нежного лосося в остром соусе",
                            _Name = "Запеченный ролл с острым лососем",
                            _Number = 29
                        },
                        new
                        {
                            Guid = new Guid("889da9d4-5187-4e98-af17-bb843896e11d"),
                            OrderGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            _Coast = 5.5m,
                            _Description = "Рис, водоросли нори, авокадо, огурец, сыр творожный, тунец, соус спайси, кунжут жареный, зелень, сыр пармезан, соус калифорния",
                            _Name = "Запеченный ролл с острым тунцом",
                            _Number = 30
                        });
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Order", b =>
                {
                    b.HasOne("Final_project.Domain.Entity.Client", "Client")
                        .WithMany("Order")
                        .HasForeignKey("ClientGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Sushi", b =>
                {
                    b.HasOne("Final_project.Domain.Entity.Order", "Order")
                        .WithMany("Sushi")
                        .HasForeignKey("OrderGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Client", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Order", b =>
                {
                    b.Navigation("Sushi");
                });
#pragma warning restore 612, 618
        }
    }
}