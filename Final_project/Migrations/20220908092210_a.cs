using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Id",
                table: "Sushi");

            migrationBuilder.AddPrimaryKey(
                name: "Key",
                table: "Sushi",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Key", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sushi",
                columns: new[] { "Id", "Coast", "Description", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("05390174-69c5-454d-bd1e-62dd258c5526"), 2.1m, "Острые суши гункан с морским окунем, приправленные специальным острым соусом спайси", "Суши с окунем (Идзуми тай Нигири)", 7 },
                    { new Guid("11294028-0053-41e9-88cf-7e63d6baf67f"), 1.2m, "Ломтики кремообразного авокадо отлично сочетаются со свежесмолотым черным перцем", "Суши с авокадо(Авокадо Нигири)", 1 },
                    { new Guid("1311d6bf-ca3a-4b65-965d-65383e0ccfef"), 4.9m, "Ролл с кальмаром, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый кальмар", 19 },
                    { new Guid("2ae717d9-02f1-4ed1-998e-00eb44a7e174"), 5.2m, "Аппетитный запечённый ролл с копчёным угрём, японским омлетом, огурцом, мидиями, майонезом, икрой капеллана и сыром Пармезан", "Запеченный ролл с копченым угрем и омлетом", 26 },
                    { new Guid("36c8d824-c489-43fe-860e-3881ddec8095"), 4.6m, "Лепные суши с моллюском хоккигаем", "Суши с моллюском Хоккигай (Хоккигай Нигири)", 6 },
                    { new Guid("4491dd8c-6a17-4610-9434-21c3d11d6fcf"), 5.9m, "Аппетитный запеченный ролл с салатным крабом, огурцом и сыром сливочным, под шапкой и соуса спайс", "Запеченный ролл Калифорния с крабом", 24 },
                    { new Guid("469243ec-effa-4395-a39d-f5d4e1cbdd2f"), 2.5m, "Лосось копченый, рис, васаби", "Суши с копченым лососем (Сяке гурме Нигири)", 3 },
                    { new Guid("4d290e21-ec2a-4704-b939-68d2bf1906a7"), 3.5m, "Суши гункан, заполненные салатом из морских водорослей вакамэ, приправленным орехово-кунжутным соусом", "Суши с салатными креветками в огурце", 16 },
                    { new Guid("544376bc-79a6-434d-af02-38599a8e7a68"), 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 10 },
                    { new Guid("54a65896-9509-4b90-ae95-690f5e110842"), 4.3m, "Теплый ролл с окунем, огурцом и соусом спайс", "Ролл Урамаки Острый морской окунь", 21 },
                    { new Guid("563cc74d-45e7-43f1-80d8-8cbccf868a19"), 4.2m, "Запеченые острые суши с мидиями в огурце, под икорно сырным острым соусом", "Суши с мидиями в огурце", 15 },
                    { new Guid("641e9877-14db-4ec9-946a-a34fa309b474"), 4.5m, "Оригинальный ролл, необычное сочетание копченой курицы и бекона со свежими овощами и спайси-соусом", "Ролл Урамаки Острый цыпленок", 23 },
                    { new Guid("646658b9-1bb5-40af-8bc0-cc5000585749"), 3.3m, "Суши гункан, заполненные икрой тобико летучей рыбы", "Суши с икрой летучей рыбы в огурце", 14 },
                    { new Guid("69b73a0d-61f2-4dd0-b571-91cbc69dd2a6"), 3.9m, "Суши гункан с нарезанным мясом крупной креветки, приправленным специальным сладким соусом", "Суши со сладкой креветкой (Ама Эби Нигири)", 13 },
                    { new Guid("6ea3e143-0f3a-46cb-9058-04f9f6723d33"), 5.3m, "Рис, нори, лосось, гребешок, крем-сыр, авокадо, спайси соус, унаги соус", "Запеченный ролл с острым гребешком", 27 },
                    { new Guid("6f7ef789-6bac-403b-8aad-07e12b96de89"), 4.2m, "Рис, нори, угорь, огурец, лосось, кимчи соус, лук зелёный", "Ролл Урамаки Острый копченый угорь", 20 },
                    { new Guid("84040bf3-1587-453f-95db-b1f6781a8eb7"), 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 11 },
                    { new Guid("98dc6ead-c67b-4720-bfb2-799a82d634eb"), 3.6m, "Любимый ролл японского водяного Каппа - ролл с огурцом цыпленком и кунжутом", "Суши с цыпленком в огурце", 17 },
                    { new Guid("a317c393-3504-42d1-92ed-2b2d9e6f3330"), 5.4m, "Кальмар, фирменная сырная шапка, соус Унаги, кунжут, рис, нори", "Запеченный ролл с острым кальмаром", 28 },
                    { new Guid("a66e3aba-b3f5-4bf6-88c3-f0b3f8dcb07f"), 1.5m, "Гребешок морской, рис, васаби", "Суши с гребешком (Хотатэгай Нигири)", 2 },
                    { new Guid("ae2e0dca-1502-4daf-95e6-970ca4d010b1"), 4m, "Гребешок, огурец, тобико, творожный сыр", "Ролл Урамаки Острый гребешок", 18 },
                    { new Guid("b0ee4dcd-ab72-4c69-b6e0-7fd8bf26638a"), 3.1m, "Оригинальный ролл с тунцом, японским омлетом, помидором и майонезом в оранжевой икре", "Суши с тунцом (Магуро Нигири)", 12 },
                    { new Guid("be7eed05-d27a-4a94-a30c-da4ef50efd40"), 5.5m, "Рис, водоросли нори, авокадо, огурец, сыр творожный, тунец, соус спайси, кунжут жареный, зелень, сыр пармезан, соус калифорния", "Запеченный ролл с острым тунцом", 30 },
                    { new Guid("bf08bb6c-b750-48da-a526-46bf3b75dcbe"), 2.2m, "Суши нигири со специальным японским слоистым омлетом тамаго, приправленным соусом унаги", "Суши с омлетом (Тамаго Нигири)", 8 },
                    { new Guid("d337dfdc-94a0-4b20-814c-cb0959c5ae1f"), 3.5m, "Суши нигири с желтохвостой лакедрой, богатой жирными кислотами и полезными микроэлементами", "Суши с лакедрой желтохвостой (Хамачи Нигири)", 4 },
                    { new Guid("d58a6857-e970-49ad-9c93-f44994fdc475"), 5.5m, "Жгучий запеченный ролл с омлетом и творожным сыром под шапочкой из нежного лосося в остром соусе", "Запеченный ролл с острым лососем", 29 },
                    { new Guid("d96ed9a5-a9ab-4003-94c3-b1fdaf6d87b4"), 4.9m, "Острые суши гункан с мясом осьминога, приправленным специальным острым соусом спайси", "Суши с осьминогом (Тако Нигири)", 9 },
                    { new Guid("da4e67bf-660f-44a0-beba-a7ad1cdf6a4a"), 1.9m, "Ролл с лососем, сливочным сыром и огурцом в оранжевой икре капеллана Масаго", "Суши с лососем (Сяке Нигири)", 5 },
                    { new Guid("e8cd8a6b-83dd-4fa2-b52e-2d6c94d5397e"), 5.9m, "Аппетитный запеченный ролл с нежным лососем, огурцом и сыром сливочным, под шапкой и майонеза", "Запеченный ролл Калифорния с лососем", 25 },
                    { new Guid("f59c3443-bad7-4fc0-adbd-28ad281c6133"), 4.4m, "Ролл с окунем, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый тунец", 22 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "Key",
                table: "Sushi");

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("05390174-69c5-454d-bd1e-62dd258c5526"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("11294028-0053-41e9-88cf-7e63d6baf67f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("1311d6bf-ca3a-4b65-965d-65383e0ccfef"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("2ae717d9-02f1-4ed1-998e-00eb44a7e174"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("36c8d824-c489-43fe-860e-3881ddec8095"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("4491dd8c-6a17-4610-9434-21c3d11d6fcf"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("469243ec-effa-4395-a39d-f5d4e1cbdd2f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("4d290e21-ec2a-4704-b939-68d2bf1906a7"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("544376bc-79a6-434d-af02-38599a8e7a68"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("54a65896-9509-4b90-ae95-690f5e110842"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("563cc74d-45e7-43f1-80d8-8cbccf868a19"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("641e9877-14db-4ec9-946a-a34fa309b474"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("646658b9-1bb5-40af-8bc0-cc5000585749"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("69b73a0d-61f2-4dd0-b571-91cbc69dd2a6"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("6ea3e143-0f3a-46cb-9058-04f9f6723d33"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("6f7ef789-6bac-403b-8aad-07e12b96de89"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("84040bf3-1587-453f-95db-b1f6781a8eb7"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("98dc6ead-c67b-4720-bfb2-799a82d634eb"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("a317c393-3504-42d1-92ed-2b2d9e6f3330"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("a66e3aba-b3f5-4bf6-88c3-f0b3f8dcb07f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("ae2e0dca-1502-4daf-95e6-970ca4d010b1"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("b0ee4dcd-ab72-4c69-b6e0-7fd8bf26638a"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("be7eed05-d27a-4a94-a30c-da4ef50efd40"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("bf08bb6c-b750-48da-a526-46bf3b75dcbe"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("d337dfdc-94a0-4b20-814c-cb0959c5ae1f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("d58a6857-e970-49ad-9c93-f44994fdc475"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("d96ed9a5-a9ab-4003-94c3-b1fdaf6d87b4"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("da4e67bf-660f-44a0-beba-a7ad1cdf6a4a"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("e8cd8a6b-83dd-4fa2-b52e-2d6c94d5397e"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Id",
                keyValue: new Guid("f59c3443-bad7-4fc0-adbd-28ad281c6133"));

            migrationBuilder.AddPrimaryKey(
                name: "Id",
                table: "Sushi",
                column: "Id");
        }
    }
}
