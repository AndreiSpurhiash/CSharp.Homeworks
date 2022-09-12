using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_project.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientGuid",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sushi_Orders_OrderGuid",
                table: "Sushi");

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("05a6dd27-d6c2-433e-9152-157814f300e4"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("100e07de-b974-48db-880b-d89d2a7a9868"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("11799502-e8d0-4bd3-bf46-582d9d4991a3"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("1ba046b7-e060-4a43-a8d3-b17e3e7363b5"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("200cad8d-30ce-4cf1-9b28-1bbd9bf1f677"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("238b7b12-fcf9-4dfe-9d36-ae0cd7b95951"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2582711a-c868-49fe-b06c-6cdc27d1367a"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2db1b137-0456-49a6-b944-ab2a91d86e06"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2f96afad-642f-4755-a027-c1f4939e3247"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2fc12007-bd66-4049-b18a-c4bcd30afee0"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2fc5a3ff-4bb4-4acb-928a-6b3cef804c79"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2fc84f56-8f62-4c00-8357-01eb035f9a59"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2fcb5494-87b0-4500-98ff-0cc918582855"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("2fdcccf9-fa85-4b31-908c-c0bf1b657bae"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("371c4ae8-3234-42d3-9f2c-e1e5a2cc2d0e"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("523d9a4f-ab3d-45a6-9170-6064f11049b4"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("5bd351b7-4f5f-46f6-ad7b-7d5d466fb81f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("60425da9-1adf-424c-9aa3-688f109ceea3"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("6370737d-be92-41b2-9f5e-165392093877"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("67cc068b-a558-43a7-b31b-09ba363be7ac"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("7224e2af-84f1-4fe9-8cae-15ebf24d17bf"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("b56adb28-7f5b-4d55-8e7c-fb5d7c68dfc1"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("c40ef5ac-9a58-4a89-b71a-b2b9dae96fc6"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("c69eb94e-5c13-4af1-a565-7121e8ca3979"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("cb4bac95-d156-4892-8d87-838ecb12d8f9"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("f0181d59-9277-41dd-8842-a2f15fdbc46a"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("f346d9d7-c269-45c2-a953-f8b9a5119373"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("f349672f-89c7-4431-a515-67cec6244a8e"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("f5be59b3-76e7-4360-88ad-f670a45e2690"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("fb6d40f1-169f-4f74-889d-cf11ea2a0a08"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderGuid",
                table: "Sushi",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientGuid",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Sushi",
                columns: new[] { "Guid", "OrderGuid", "Coast", "Description", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("aa938e6c-cfa3-4bba-a948-436e8cacbc1e"), new Guid("00000000-0000-0000-0000-000000000000"), 1.2m, "Ломтики кремообразного авокадо отлично сочетаются со свежесмолотым черным перцем", "Суши с авокадо(Авокадо Нигири)", 1 },
                    { new Guid("e67b7118-3f55-4e56-904f-46b78a6d1c32"), new Guid("00000000-0000-0000-0000-000000000000"), 5.4m, "Кальмар, фирменная сырная шапка, соус Унаги, кунжут, рис, нори", "Запеченный ролл с острым кальмаром", 28 },
                    { new Guid("eda10871-7683-451f-9722-38c17056243d"), new Guid("00000000-0000-0000-0000-000000000000"), 5.3m, "Рис, нори, лосось, гребешок, крем-сыр, авокадо, спайси соус, унаги соус", "Запеченный ролл с острым гребешком", 27 },
                    { new Guid("3b7add4b-95b1-4f66-b9dd-af891b63f27c"), new Guid("00000000-0000-0000-0000-000000000000"), 5.2m, "Аппетитный запечённый ролл с копчёным угрём, японским омлетом, огурцом, мидиями, майонезом, икрой капеллана и сыром Пармезан", "Запеченный ролл с копченым угрем и омлетом", 26 },
                    { new Guid("4fcebf79-e8db-4845-9e0c-cd39e3833812"), new Guid("00000000-0000-0000-0000-000000000000"), 5.9m, "Аппетитный запеченный ролл с нежным лососем, огурцом и сыром сливочным, под шапкой и майонеза", "Запеченный ролл Калифорния с лососем", 25 },
                    { new Guid("aabf5e03-baef-4c0c-be76-475e86f3ab0b"), new Guid("00000000-0000-0000-0000-000000000000"), 5.9m, "Аппетитный запеченный ролл с салатным крабом, огурцом и сыром сливочным, под шапкой и соуса спайс", "Запеченный ролл Калифорния с крабом", 24 },
                    { new Guid("12878923-7eea-47ac-a90e-845fd89f5ee3"), new Guid("00000000-0000-0000-0000-000000000000"), 4.5m, "Оригинальный ролл, необычное сочетание копченой курицы и бекона со свежими овощами и спайси-соусом", "Ролл Урамаки Острый цыпленок", 23 },
                    { new Guid("5bc15174-9c9a-4577-a594-90a1f482991f"), new Guid("00000000-0000-0000-0000-000000000000"), 4.4m, "Ролл с окунем, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый тунец", 22 },
                    { new Guid("cc56f405-097d-45fb-831f-0704ffadb4f6"), new Guid("00000000-0000-0000-0000-000000000000"), 4.3m, "Теплый ролл с окунем, огурцом и соусом спайс", "Ролл Урамаки Острый морской окунь", 21 },
                    { new Guid("b525698f-1e9e-4376-9905-ff0192659b2b"), new Guid("00000000-0000-0000-0000-000000000000"), 4.2m, "Рис, нори, угорь, огурец, лосось, кимчи соус, лук зелёный", "Ролл Урамаки Острый копченый угорь", 20 },
                    { new Guid("869352a2-e387-4a06-bc34-518e814a5733"), new Guid("00000000-0000-0000-0000-000000000000"), 4.9m, "Ролл с кальмаром, японским омлетом, икрой летучей рыбы и стружкой тунца", "Ролл Урамаки Острый кальмар", 19 },
                    { new Guid("a46b4450-794f-4d55-9645-6a9e55cb4e60"), new Guid("00000000-0000-0000-0000-000000000000"), 4m, "Гребешок, огурец, тобико, творожный сыр", "Ролл Урамаки Острый гребешок", 18 },
                    { new Guid("3cd8e391-4a85-4226-94f4-f5f93fea8d2c"), new Guid("00000000-0000-0000-0000-000000000000"), 3.6m, "Любимый ролл японского водяного Каппа - ролл с огурцом цыпленком и кунжутом", "Суши с цыпленком в огурце", 17 },
                    { new Guid("fdb238d1-8eb1-4f83-8ece-0b34e0291819"), new Guid("00000000-0000-0000-0000-000000000000"), 3.5m, "Суши гункан, заполненные салатом из морских водорослей вакамэ, приправленным орехово-кунжутным соусом", "Суши с салатными креветками в огурце", 16 },
                    { new Guid("224556b3-27fe-4972-a70a-2744a7f32cce"), new Guid("00000000-0000-0000-0000-000000000000"), 4.2m, "Запеченые острые суши с мидиями в огурце, под икорно сырным острым соусом", "Суши с мидиями в огурце", 15 },
                    { new Guid("774998f1-a816-49f2-ba33-f8720abecce4"), new Guid("00000000-0000-0000-0000-000000000000"), 3.3m, "Суши гункан, заполненные икрой тобико летучей рыбы", "Суши с икрой летучей рыбы в огурце", 14 },
                    { new Guid("a875048e-3eb4-45da-9f47-303981cf4294"), new Guid("00000000-0000-0000-0000-000000000000"), 3.9m, "Суши гункан с нарезанным мясом крупной креветки, приправленным специальным сладким соусом", "Суши со сладкой креветкой (Ама Эби Нигири)", 13 },
                    { new Guid("8e738411-e60a-4567-a8f3-e12ee4a32f23"), new Guid("00000000-0000-0000-0000-000000000000"), 3.1m, "Оригинальный ролл с тунцом, японским омлетом, помидором и майонезом в оранжевой икре", "Суши с тунцом (Магуро Нигири)", 12 },
                    { new Guid("85a3a000-6e43-4205-b357-e98dcd556de1"), new Guid("00000000-0000-0000-0000-000000000000"), 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 11 },
                    { new Guid("ae3442e3-8410-4928-a962-3d7edd20b01c"), new Guid("00000000-0000-0000-0000-000000000000"), 3m, "Запеченые острые суши с крупной креветкой, под икорно-сырным острым соусом", "Суши с тигровой креветкой (Эби Нигири)", 10 },
                    { new Guid("c96d6436-be1e-46ea-a048-7d5c2175b675"), new Guid("00000000-0000-0000-0000-000000000000"), 4.9m, "Острые суши гункан с мясом осьминога, приправленным специальным острым соусом спайси", "Суши с осьминогом (Тако Нигири)", 9 },
                    { new Guid("1db147a5-b51c-4e53-aac5-7f6010540a72"), new Guid("00000000-0000-0000-0000-000000000000"), 2.2m, "Суши нигири со специальным японским слоистым омлетом тамаго, приправленным соусом унаги", "Суши с омлетом (Тамаго Нигири)", 8 },
                    { new Guid("1f9c7537-5cb6-4da2-a8ae-45c9057291e0"), new Guid("00000000-0000-0000-0000-000000000000"), 2.1m, "Острые суши гункан с морским окунем, приправленные специальным острым соусом спайси", "Суши с окунем (Идзуми тай Нигири)", 7 },
                    { new Guid("4653a585-b318-417f-a37d-254cd00f35d5"), new Guid("00000000-0000-0000-0000-000000000000"), 4.6m, "Лепные суши с моллюском хоккигаем", "Суши с моллюском Хоккигай (Хоккигай Нигири)", 6 },
                    { new Guid("90340c09-db6e-4dd4-bfc2-07db241a11e3"), new Guid("00000000-0000-0000-0000-000000000000"), 1.9m, "Ролл с лососем, сливочным сыром и огурцом в оранжевой икре капеллана Масаго", "Суши с лососем (Сяке Нигири)", 5 },
                    { new Guid("54c239de-445c-482b-9239-1bfacaca1139"), new Guid("00000000-0000-0000-0000-000000000000"), 3.5m, "Суши нигири с желтохвостой лакедрой, богатой жирными кислотами и полезными микроэлементами", "Суши с лакедрой желтохвостой (Хамачи Нигири)", 4 },
                    { new Guid("d228a9d2-fc82-4933-80bb-16b92ca2a5b2"), new Guid("00000000-0000-0000-0000-000000000000"), 2.5m, "Лосось копченый, рис, васаби", "Суши с копченым лососем (Сяке гурме Нигири)", 3 },
                    { new Guid("b39e3832-022b-467a-927f-7965f1df9f80"), new Guid("00000000-0000-0000-0000-000000000000"), 1.5m, "Гребешок морской, рис, васаби", "Суши с гребешком (Хотатэгай Нигири)", 2 },
                    { new Guid("8159f80e-09f4-4074-9a1c-db6cbe2ec296"), new Guid("00000000-0000-0000-0000-000000000000"), 5.5m, "Жгучий запеченный ролл с омлетом и творожным сыром под шапочкой из нежного лосося в остром соусе", "Запеченный ролл с острым лососем", 29 },
                    { new Guid("889da9d4-5187-4e98-af17-bb843896e11d"), new Guid("00000000-0000-0000-0000-000000000000"), 5.5m, "Рис, водоросли нори, авокадо, огурец, сыр творожный, тунец, соус спайси, кунжут жареный, зелень, сыр пармезан, соус калифорния", "Запеченный ролл с острым тунцом", 30 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientGuid",
                table: "Orders",
                column: "ClientGuid",
                principalTable: "Clients",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sushi_Orders_OrderGuid",
                table: "Sushi",
                column: "OrderGuid",
                principalTable: "Orders",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientGuid",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sushi_Orders_OrderGuid",
                table: "Sushi");

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("12878923-7eea-47ac-a90e-845fd89f5ee3"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("1db147a5-b51c-4e53-aac5-7f6010540a72"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("1f9c7537-5cb6-4da2-a8ae-45c9057291e0"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("224556b3-27fe-4972-a70a-2744a7f32cce"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("3b7add4b-95b1-4f66-b9dd-af891b63f27c"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("3cd8e391-4a85-4226-94f4-f5f93fea8d2c"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("4653a585-b318-417f-a37d-254cd00f35d5"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("4fcebf79-e8db-4845-9e0c-cd39e3833812"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("54c239de-445c-482b-9239-1bfacaca1139"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("5bc15174-9c9a-4577-a594-90a1f482991f"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("774998f1-a816-49f2-ba33-f8720abecce4"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("8159f80e-09f4-4074-9a1c-db6cbe2ec296"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("85a3a000-6e43-4205-b357-e98dcd556de1"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("869352a2-e387-4a06-bc34-518e814a5733"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("889da9d4-5187-4e98-af17-bb843896e11d"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("8e738411-e60a-4567-a8f3-e12ee4a32f23"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("90340c09-db6e-4dd4-bfc2-07db241a11e3"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("a46b4450-794f-4d55-9645-6a9e55cb4e60"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("a875048e-3eb4-45da-9f47-303981cf4294"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("aa938e6c-cfa3-4bba-a948-436e8cacbc1e"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("aabf5e03-baef-4c0c-be76-475e86f3ab0b"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("ae3442e3-8410-4928-a962-3d7edd20b01c"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("b39e3832-022b-467a-927f-7965f1df9f80"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("b525698f-1e9e-4376-9905-ff0192659b2b"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("c96d6436-be1e-46ea-a048-7d5c2175b675"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("cc56f405-097d-45fb-831f-0704ffadb4f6"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("d228a9d2-fc82-4933-80bb-16b92ca2a5b2"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("e67b7118-3f55-4e56-904f-46b78a6d1c32"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("eda10871-7683-451f-9722-38c17056243d"));

            migrationBuilder.DeleteData(
                table: "Sushi",
                keyColumn: "Guid",
                keyValue: new Guid("fdb238d1-8eb1-4f83-8ece-0b34e0291819"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderGuid",
                table: "Sushi",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientGuid",
                table: "Orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientGuid",
                table: "Orders",
                column: "ClientGuid",
                principalTable: "Clients",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sushi_Orders_OrderGuid",
                table: "Sushi",
                column: "OrderGuid",
                principalTable: "Orders",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
