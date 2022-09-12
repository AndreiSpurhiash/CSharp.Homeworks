using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_project.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "text", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "text", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id1", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id2", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "Clients",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sushi",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Coast = table.Column<decimal>(type: "numeric(38,17)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    OrderGuid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Key", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Sushi_Orders_OrderGuid",
                        column: x => x.OrderGuid,
                        principalTable: "Orders",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Sushi",
                columns: new[] { "Guid", "OrderGuid", "Coast", "Description", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("200cad8d-30ce-4cf1-9b28-1bbd9bf1f677"), null, 1.2m, "Ломтики кремообразного авокадо отлично сочетаются со свежесмолотым черным перцем", "Суши с авокадо(Авокадо Нигири)", 1 },
                    { new Guid("100e07de-b974-48db-880b-d89d2a7a9868"), null, 5.4m, "Кальмар, фирменная сырная шапка, соус Унаги, кунжут, рис, нори", "Запеченный ролл с острым кальмаром", 28 },
                    { new Guid("2db1b137-0456-49a6-b944-ab2a91d86e06"), null, 5.3m, "Рис, нори, лосось, гребешок, крем-сыр, авокадо, спайси соус, унаги соус", "Запеченный ролл с острым гребешком", 27 },
                    { new Guid("2fc5a3ff-4bb4-4acb-928a-6b3cef804c79"), null, 5.2m, "Аппетитный запечённый ролл с копчёным угрём, японским омлетом, огурцом, мидиями, майонезом, икрой капеллана и сыром Пармезан", "Запеченный ролл с копченым угрем и омлетом", 26 },
                    { new Guid("1ba046b7-e060-4a43-a8d3-b17e3e7363b5"), null, 5.9m, "Аппетитный запеченный ролл с нежным лососем, огурцом и сыром сливочным, под шапкой и майонеза", "Запеченный ролл Калифорния с лососем", 25 },
                    { new Guid("c69eb94e-5c13-4af1-a565-7121e8ca3979"), null, 5.9m, "Аппетитный запеченный ролл с салатным крабом, огурцом и сыром сливочным, под шапкой и соуса спайс", "Запеченный ролл Калифорния с крабом", 24 },
                    { new Guid("238b7b12-fcf9-4dfe-9d36-ae0cd7b95951"), null, 4.5m, "Оригинальный ролл, необычное сочетание копченой курицы и бекона со свежими овощами и спайси-соусом", "Ролл Урамаки Острый цыпленок", 23 },
                    { new Guid("67cc068b-a558-43a7-b31b-09ba363be7ac"), null, 4.4m, "Ролл с окунем, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый тунец", 22 },
                    { new Guid("f5be59b3-76e7-4360-88ad-f670a45e2690"), null, 4.3m, "Теплый ролл с окунем, огурцом и соусом спайс", "Ролл Урамаки Острый морской окунь", 21 },
                    { new Guid("2f96afad-642f-4755-a027-c1f4939e3247"), null, 4.2m, "Рис, нори, угорь, огурец, лосось, кимчи соус, лук зелёный", "Ролл Урамаки Острый копченый угорь", 20 },
                    { new Guid("7224e2af-84f1-4fe9-8cae-15ebf24d17bf"), null, 4.9m, "Ролл с кальмаром, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый кальмар", 19 },
                    { new Guid("11799502-e8d0-4bd3-bf46-582d9d4991a3"), null, 4m, "Гребешок, огурец, тобико, творожный сыр", "Ролл Урамаки Острый гребешок", 18 },
                    { new Guid("2fdcccf9-fa85-4b31-908c-c0bf1b657bae"), null, 3.6m, "Любимый ролл японского водяного Каппа - ролл с огурцом цыпленком и кунжутом", "Суши с цыпленком в огурце", 17 },
                    { new Guid("f349672f-89c7-4431-a515-67cec6244a8e"), null, 3.5m, "Суши гункан, заполненные салатом из морских водорослей вакамэ, приправленным орехово-кунжутным соусом", "Суши с салатными креветками в огурце", 16 },
                    { new Guid("fb6d40f1-169f-4f74-889d-cf11ea2a0a08"), null, 4.2m, "Запеченые острые суши с мидиями в огурце, под икорно сырным острым соусом", "Суши с мидиями в огурце", 15 },
                    { new Guid("f0181d59-9277-41dd-8842-a2f15fdbc46a"), null, 3.3m, "Суши гункан, заполненные икрой тобико летучей рыбы", "Суши с икрой летучей рыбы в огурце", 14 },
                    { new Guid("b56adb28-7f5b-4d55-8e7c-fb5d7c68dfc1"), null, 3.9m, "Суши гункан с нарезанным мясом крупной креветки, приправленным специальным сладким соусом", "Суши со сладкой креветкой (Ама Эби Нигири)", 13 },
                    { new Guid("5bd351b7-4f5f-46f6-ad7b-7d5d466fb81f"), null, 3.1m, "Оригинальный ролл с тунцом, японским омлетом, помидором и майонезом в оранжевой икре", "Суши с тунцом (Магуро Нигири)", 12 },
                    { new Guid("371c4ae8-3234-42d3-9f2c-e1e5a2cc2d0e"), null, 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 11 },
                    { new Guid("f346d9d7-c269-45c2-a953-f8b9a5119373"), null, 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 10 },
                    { new Guid("6370737d-be92-41b2-9f5e-165392093877"), null, 4.9m, "Острые суши гункан с мясом осьминога, приправленным специальным острым соусом спайси", "Суши с осьминогом (Тако Нигири)", 9 },
                    { new Guid("2582711a-c868-49fe-b06c-6cdc27d1367a"), null, 2.2m, "Суши нигири со специальным японским слоистым омлетом тамаго, приправленным соусом унаги", "Суши с омлетом (Тамаго Нигири)", 8 },
                    { new Guid("523d9a4f-ab3d-45a6-9170-6064f11049b4"), null, 2.1m, "Острые суши гункан с морским окунем, приправленные специальным острым соусом спайси", "Суши с окунем (Идзуми тай Нигири)", 7 },
                    { new Guid("2fcb5494-87b0-4500-98ff-0cc918582855"), null, 4.6m, "Лепные суши с моллюском хоккигаем", "Суши с моллюском Хоккигай (Хоккигай Нигири)", 6 },
                    { new Guid("60425da9-1adf-424c-9aa3-688f109ceea3"), null, 1.9m, "Ролл с лососем, сливочным сыром и огурцом в оранжевой икре капеллана Масаго", "Суши с лососем (Сяке Нигири)", 5 },
                    { new Guid("cb4bac95-d156-4892-8d87-838ecb12d8f9"), null, 3.5m, "Суши нигири с желтохвостой лакедрой, богатой жирными кислотами и полезными микроэлементами", "Суши с лакедрой желтохвостой (Хамачи Нигири)", 4 },
                    { new Guid("2fc84f56-8f62-4c00-8357-01eb035f9a59"), null, 2.5m, "Лосось копченый, рис, васаби", "Суши с копченым лососем (Сяке гурме Нигири)", 3 },
                    { new Guid("05a6dd27-d6c2-433e-9152-157814f300e4"), null, 1.5m, "Гребешок морской, рис, васаби", "Суши с гребешком (Хотатэгай Нигири)", 2 },
                    { new Guid("c40ef5ac-9a58-4a89-b71a-b2b9dae96fc6"), null, 5.5m, "Жгучий запеченный ролл с омлетом и творожным сыром под шапочкой из нежного лосося в остром соусе", "Запеченный ролл с острым лососем", 29 },
                    { new Guid("2fc12007-bd66-4049-b18a-c4bcd30afee0"), null, 5.5m, "Рис, водоросли нори, авокадо, огурец, сыр творожный, тунец, соус спайси, кунжут жареный, зелень, сыр пармезан, соус калифорния", "Запеченный ролл с острым тунцом", 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientGuid",
                table: "Orders",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Sushi_OrderGuid",
                table: "Sushi",
                column: "OrderGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sushi");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
