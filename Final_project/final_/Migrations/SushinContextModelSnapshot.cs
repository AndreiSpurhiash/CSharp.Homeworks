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

            modelBuilder.Entity("Final_project.Domain.Entity.Basket", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasColumnName("Count");

                    b.Property<Guid>("GuidOrder")
                        .HasColumnType("uuid")
                        .HasColumnName("GuidOrder");

                    b.Property<Guid?>("SushiGuid")
                        .HasColumnType("uuid");

                    b.HasKey("Guid")
                        .HasName("Id3");

                    b.HasIndex("GuidOrder");

                    b.HasIndex("SushiGuid");

                    b.ToTable("Basket");
                });

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

                    b.ToTable("Sushi");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("8d4d48cb-5caf-48d9-8838-d78e475f72bb"),
                            _Coast = 1.2m,
                            _Description = "Ломтики кремообразного авокадо отлично сочетаются со свежесмолотым черным перцем",
                            _Name = "Суши с авокадо(Авокадо Нигири)",
                            _Number = 1
                        },
                        new
                        {
                            Guid = new Guid("ecaca885-22d0-404a-b489-d3369e9482bf"),
                            _Coast = 1.5m,
                            _Description = "Гребешок морской, рис, васаби",
                            _Name = "Суши с гребешком (Хотатэгай Нигири)",
                            _Number = 2
                        },
                        new
                        {
                            Guid = new Guid("2d3ddb51-5878-4217-84eb-3267882064cb"),
                            _Coast = 2.5m,
                            _Description = "Лосось копченый, рис, васаби",
                            _Name = "Суши с копченым лососем (Сяке гурме Нигири)",
                            _Number = 3
                        },
                        new
                        {
                            Guid = new Guid("258804e6-6b1c-45a0-8d4c-87e10aa1a8be"),
                            _Coast = 3.5m,
                            _Description = "Суши нигири с желтохвостой лакедрой, богатой жирными кислотами и полезными микроэлементами",
                            _Name = "Суши с лакедрой желтохвостой (Хамачи Нигири)",
                            _Number = 4
                        },
                        new
                        {
                            Guid = new Guid("7e0224f9-d7f9-455f-8510-c00555d64feb"),
                            _Coast = 1.9m,
                            _Description = "Ролл с лососем, сливочным сыром и огурцом в оранжевой икре капеллана Масаго",
                            _Name = "Суши с лососем (Сяке Нигири)",
                            _Number = 5
                        },
                        new
                        {
                            Guid = new Guid("2554a973-4c97-4212-a540-f104c3050a55"),
                            _Coast = 4.6m,
                            _Description = "Лепные суши с моллюском хоккигаем",
                            _Name = "Суши с моллюском Хоккигай (Хоккигай Нигири)",
                            _Number = 6
                        },
                        new
                        {
                            Guid = new Guid("6ab21210-5e84-48b6-ac0e-74ad65d4b1dd"),
                            _Coast = 2.1m,
                            _Description = "Острые суши гункан с морским окунем, приправленные специальным острым соусом спайси",
                            _Name = "Суши с окунем (Идзуми тай Нигири)",
                            _Number = 7
                        },
                        new
                        {
                            Guid = new Guid("fbea56c8-87cb-4068-ba7b-a89f1676f9bf"),
                            _Coast = 2.2m,
                            _Description = "Суши нигири со специальным японским слоистым омлетом тамаго, приправленным соусом унаги",
                            _Name = "Суши с омлетом (Тамаго Нигири)",
                            _Number = 8
                        },
                        new
                        {
                            Guid = new Guid("6f1f0d8e-24d1-46ef-b3b1-80ffe9c6a0f4"),
                            _Coast = 4.9m,
                            _Description = "Острые суши гункан с мясом осьминога, приправленным специальным острым соусом спайси",
                            _Name = "Суши с осьминогом (Тако Нигири)",
                            _Number = 9
                        },
                        new
                        {
                            Guid = new Guid("b93ef713-cb81-4510-ae0c-e357cb2035d9"),
                            _Coast = 3m,
                            _Description = "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом",
                            _Name = "Суши с тигровой креветкой (Эби Нигири)",
                            _Number = 10
                        },
                        new
                        {
                            Guid = new Guid("d61a3153-9b40-4dbb-a3ad-2041108f1f30"),
                            _Coast = 3m,
                            _Description = "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом",
                            _Name = "Суши с тигровой креветкой (Эби Нигири)",
                            _Number = 11
                        },
                        new
                        {
                            Guid = new Guid("458accbc-4807-4217-978b-1a914ebfd12d"),
                            _Coast = 3.1m,
                            _Description = "Оригинальный ролл с тунцом, японским омлетом, помидором и майонезом в оранжевой икре",
                            _Name = "Суши с тунцом (Магуро Нигири)",
                            _Number = 12
                        },
                        new
                        {
                            Guid = new Guid("7c81d427-47f0-4021-87d1-1b5dc9467e7f"),
                            _Coast = 3.9m,
                            _Description = "Суши гункан с нарезанным мясом крупной креветки, приправленным специальным сладким соусом",
                            _Name = "Суши со сладкой креветкой (Ама Эби Нигири)",
                            _Number = 13
                        },
                        new
                        {
                            Guid = new Guid("190390e3-f258-4099-a8da-c1158c0303d9"),
                            _Coast = 3.3m,
                            _Description = "Суши гункан, заполненные икрой тобико летучей рыбы",
                            _Name = "Суши с икрой летучей рыбы в огурце",
                            _Number = 14
                        },
                        new
                        {
                            Guid = new Guid("c165c3ad-1ab7-4923-a161-fd23817a9411"),
                            _Coast = 4.2m,
                            _Description = "Запеченые острые суши с мидиями в огурце, под икорно сырным острым соусом",
                            _Name = "Суши с мидиями в огурце",
                            _Number = 15
                        },
                        new
                        {
                            Guid = new Guid("b7976852-b3d1-40a1-a89f-2d12425eed4a"),
                            _Coast = 3.5m,
                            _Description = "Суши гункан, заполненные салатом из морских водорослей вакамэ, приправленным орехово-кунжутным соусом",
                            _Name = "Суши с салатными креветками в огурце",
                            _Number = 16
                        },
                        new
                        {
                            Guid = new Guid("c7ad6b95-971c-4059-8eba-86d3d50ab50c"),
                            _Coast = 3.6m,
                            _Description = "Любимый ролл японского водяного Каппа - ролл с огурцом цыпленком и кунжутом",
                            _Name = "Суши с цыпленком в огурце",
                            _Number = 17
                        },
                        new
                        {
                            Guid = new Guid("05e621e7-6371-4b58-bcd1-7591441a0ebc"),
                            _Coast = 4m,
                            _Description = "Гребешок, огурец, тобико, творожный сыр",
                            _Name = "Ролл Урамаки Острый гребешок",
                            _Number = 18
                        },
                        new
                        {
                            Guid = new Guid("2fb01260-5519-431b-9d15-5590b860d001"),
                            _Coast = 4.9m,
                            _Description = "Ролл с кальмаром, японским омлетом, икрой летучей рыбы и стружкой тунца",
                            _Name = "Ролл Урамаки Острый кальмар",
                            _Number = 19
                        },
                        new
                        {
                            Guid = new Guid("d7ec489a-d877-4ecd-8295-74cff0ea95f2"),
                            _Coast = 4.2m,
                            _Description = "Рис, нори, угорь, огурец, лосось, кимчи соус, лук зелёный",
                            _Name = "Ролл Урамаки Острый копченый угорь",
                            _Number = 20
                        },
                        new
                        {
                            Guid = new Guid("64a5e578-8243-44a4-93f8-30f09cf88ac2"),
                            _Coast = 4.3m,
                            _Description = "Теплый ролл с окунем, огурцом и соусом спайс",
                            _Name = "Ролл Урамаки Острый морской окунь",
                            _Number = 21
                        },
                        new
                        {
                            Guid = new Guid("47cae744-620a-43c6-982f-857248ce8dcf"),
                            _Coast = 4.4m,
                            _Description = "Ролл с окунем, японским омлетом, икрой летучей рыбы и стружкой тунца",
                            _Name = "Ролл Урамаки Острый тунец",
                            _Number = 22
                        },
                        new
                        {
                            Guid = new Guid("8eb2ca02-ed53-445a-b071-29a40752b62a"),
                            _Coast = 4.5m,
                            _Description = "Оригинальный ролл, необычное сочетание копченой курицы и бекона со свежими овощами и спайси-соусом",
                            _Name = "Ролл Урамаки Острый цыпленок",
                            _Number = 23
                        },
                        new
                        {
                            Guid = new Guid("978eccdb-209e-40e7-980f-b2df1ecdae76"),
                            _Coast = 5.9m,
                            _Description = "Аппетитный запеченный ролл с салатным крабом, огурцом и сыром сливочным, под шапкой и соуса спайс",
                            _Name = "Запеченный ролл Калифорния с крабом",
                            _Number = 24
                        },
                        new
                        {
                            Guid = new Guid("61ae9c5a-8e8f-44c0-ad9b-95d3d8fd819c"),
                            _Coast = 5.9m,
                            _Description = "Аппетитный запеченный ролл с нежным лососем, огурцом и сыром сливочным, под шапкой и майонеза",
                            _Name = "Запеченный ролл Калифорния с лососем",
                            _Number = 25
                        },
                        new
                        {
                            Guid = new Guid("c997fc8b-a862-4bc1-a5a4-1135c708f400"),
                            _Coast = 5.2m,
                            _Description = "Аппетитный запечённый ролл с копчёным угрём, японским омлетом, огурцом, мидиями, майонезом, икрой капеллана и сыром Пармезан",
                            _Name = "Запеченный ролл с копченым угрем и омлетом",
                            _Number = 26
                        },
                        new
                        {
                            Guid = new Guid("208ebcbc-86de-45aa-8bfe-72986e094e17"),
                            _Coast = 5.3m,
                            _Description = "Рис, нори, лосось, гребешок, крем-сыр, авокадо, спайси соус, унаги соус",
                            _Name = "Запеченный ролл с острым гребешком",
                            _Number = 27
                        },
                        new
                        {
                            Guid = new Guid("611b0e2b-98f6-414a-84f8-5664b52b2324"),
                            _Coast = 5.4m,
                            _Description = "Кальмар, фирменная сырная шапка, соус Унаги, кунжут, рис, нори",
                            _Name = "Запеченный ролл с острым кальмаром",
                            _Number = 28
                        },
                        new
                        {
                            Guid = new Guid("1ffb09aa-e78b-4509-b99d-599c14a70fb9"),
                            _Coast = 5.5m,
                            _Description = "Жгучий запеченный ролл с омлетом и творожным сыром под шапочкой из нежного лосося в остром соусе",
                            _Name = "Запеченный ролл с острым лососем",
                            _Number = 29
                        },
                        new
                        {
                            Guid = new Guid("35cc8ea3-1173-4ec0-b224-350b8fbfd2e8"),
                            _Coast = 5.5m,
                            _Description = "Рис, водоросли нори, авокадо, огурец, сыр творожный, тунец, соус спайси, кунжут жареный, зелень, сыр пармезан, соус калифорния",
                            _Name = "Запеченный ролл с острым тунцом",
                            _Number = 30
                        });
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Basket", b =>
                {
                    b.HasOne("Final_project.Domain.Entity.Order", "Order")
                        .WithMany("Basket")
                        .HasForeignKey("GuidOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_project.Domain.Entity.Sushi", "Sushi")
                        .WithMany()
                        .HasForeignKey("SushiGuid");

                    b.Navigation("Order");

                    b.Navigation("Sushi");
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

            modelBuilder.Entity("Final_project.Domain.Entity.Client", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Final_project.Domain.Entity.Order", b =>
                {
                    b.Navigation("Basket");
                });
#pragma warning restore 612, 618
        }
    }
}