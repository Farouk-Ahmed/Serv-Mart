using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4f5563-ff39-4742-a9d4-b58fbef11fe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4017e06-ea82-4377-8105-dd7c1f02759b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6ccf83-ac28-467b-9e94-c063b1425a6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0745a1-8257-4fb9-9c03-673d5d4d5f35");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("04fcb487-7f14-493c-8147-defdd481c00c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("084338ef-fd6d-4e84-b785-61c6ec1b0f9e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("11dac313-b884-4586-9674-4fff08126bb7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("15b9eca5-2c6e-4c9d-90d0-0aeaa0140d65"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1d493042-6c80-4006-bbf5-d3b90479ed50"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1fff2638-7f5d-4f61-a374-7d587dc1261d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("216c452a-aa8c-4a73-86d4-88cb6a54f931"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2855b333-f8af-43ac-9580-7a9227debe83"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2aaaebc5-852f-48cf-8bbe-49ab312b8e72"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("31b72b47-9851-4790-b417-329d1a9a9417"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("36fc5f12-3f83-47bb-9449-26affe1a7d1a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("44b98042-c992-410c-8e95-4b34546982e4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("50daf00c-2158-4235-ac6c-fd248bd37e7b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5712117a-65ef-450e-b2e6-428228438f69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5ea129bc-8bda-4c0b-a2ce-c13295daedd6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("65d2d409-eda1-4670-b10c-53be0167f6f5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("675d1c7d-9518-415c-ae61-380f5d480736"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("70c14eaf-4ad0-4e85-8305-3ea21840a0ad"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("70fd11e6-ae7d-488a-8cef-0c33f2db3083"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7d026ce2-f351-4043-8455-bab4689b8620"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("824a4ad7-d072-495a-83ff-111eee89e251"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8427b10a-2776-493c-8646-4ad4d388da7e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8bd2d0f2-bfd2-42b1-a26f-c82861c2f7b4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("96bd8440-5049-49c3-a615-8b514e88a9d5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("98d12fcb-8dbc-4e8f-a693-719c1c2fbe85"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9ae5cbfd-7126-4622-8e35-4893e0853ad4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9cc78d9e-ab76-45d6-8954-1f4d49f91c7a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad271563-a20a-47f8-b996-05859518d926"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b02b95db-fbcb-476c-a91f-bd8e8573a3cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b16ec128-efe0-4ca7-be17-b8d27af7ab01"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b2aea1c5-56a2-4a13-9be3-698e21daed47"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b364aaf7-9838-4176-9480-a5c79eb0e2c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b8339e38-22d6-4276-a7d0-a14a52822e82"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bded84fd-ff0d-477b-a6a9-2bb1765f8d49"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c18c4bbd-660b-48d0-b9d9-210270eaeb25"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c2968b24-788d-49a4-becc-8ed5f1e57afc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c6db9a25-e765-455b-9b4a-0d7fdd3c7dbe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cbc3a2de-f15f-42b8-b609-59380082e218"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf71277d-589b-449c-912e-ac5d45c13294"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d7745138-55ac-433f-a5bc-f57142e259b1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d77cd269-5831-43a5-8491-1f0aa7ecfa5e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("da0424c2-ebd0-4f1e-a220-abbbe0309ce5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dddab3c6-b092-45a3-8e92-21910f78e6ed"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de18e658-1b3d-415f-be44-f2b74c72835d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e5bf3e6f-1c4c-45fe-98ae-dcdcbdb4e29b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ecd4cf66-1863-4399-a56d-f4b31889e9fc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fb1bb09a-0657-4bb9-9984-e798bc1df72c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc49dcbb-dc7b-4527-a23e-35bb82eb06c4"));

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d21147c-1a37-4842-b2b2-0b1a9a53db5d", null, "Customer", "CUSTOMER" },
                    { "986672e2-f323-4069-91a4-b2b5ad05c76e", null, "Admin", "ADMIN" },
                    { "b44f5de8-8dc2-4a79-8b1e-20162ea888c6", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "c8c630f5-59e1-4d2f-b5e0-f22215b86e82", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("012da843-036d-425b-9ac1-41483ea506de"), "سباكة", "Plumbing" },
                    { new Guid("04108041-4756-4315-8f58-e9e38f41c7aa"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("0d30ed1c-f5cb-47dd-9875-d03fc9228a3a"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("1109ef1a-9be9-4c47-9062-7a0b5c6b7666"), "المكتبات", "Libraries" },
                    { new Guid("13f927ac-073f-4c07-b6e3-295b29c4942c"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("18313828-660f-4bc3-867b-e7291ef947d2"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("1ff5168b-0dcf-42a8-b477-2b9c9d6f0cbd"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("2103215f-a566-44d3-b3f1-712649a3e01f"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("21f1e211-0762-449d-bbc8-d207157093ea"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("26f6a213-cbef-459f-9176-d32e750571c4"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("2b4ba0e2-1103-44bc-919d-65c2d8fadcff"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("2cc58f5f-ecb8-4382-a5c4-d3be96787904"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("392ca14c-0b61-4a81-a4a5-e598a3242f2a"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("40abd534-d240-41c4-af90-9fb1ef707da8"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("41fac844-d898-4419-8072-2f976fa942b3"), "خدمات الترجمة", "Translation services" },
                    { new Guid("42a2ab89-ecf8-4bc8-80d8-512397bb61da"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("468e09d5-792c-46a7-ae66-ab5b392190de"), "خدمات التجميل", "Beauty services" },
                    { new Guid("4b0b3430-4aad-427e-9b20-923d1b3c83f6"), "البناء", "Construction" },
                    { new Guid("53d7dc67-3059-476f-b22c-185a8ab12195"), "كهرباء", "Electricity" },
                    { new Guid("5b0ce8c6-8022-4274-986c-8486148c58d2"), "تأمين", "Insurance" },
                    { new Guid("5b1b8a00-0d1a-4bfd-b07e-a313f62c6362"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("5e194697-a2fd-4b21-9165-c2606ce47239"), "خدمات قانونية", "Legal services" },
                    { new Guid("710bf60a-be5b-4a65-afc4-94a110f6d6af"), "خدمات النقل", "Transportation services" },
                    { new Guid("732472b5-f1a8-4b5c-b584-75f0e4e4ee4f"), "الخدمات المالية", "Financial services" },
                    { new Guid("79c9eeb7-9b30-4372-a44c-366704808b2b"), "المحاسبة", "Accounting" },
                    { new Guid("7f8517c8-e6fe-491e-9888-fafff45402f8"), "ضيافة", "Hospitality" },
                    { new Guid("8112e317-65e6-4b54-a553-ebed21e0d41d"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("82dd2bd4-41f8-475c-9aac-2e6abdf9837a"), "تقديم الطعام", "Catering " },
                    { new Guid("85a86ca2-dbed-4a82-a1f3-987e741ca9b7"), "تسقيف", "Roofing" },
                    { new Guid("8c4f7e26-3e20-45f7-89ec-76206b17a3f4"), "التكييف", "Air conditioning" },
                    { new Guid("921d6d51-579a-4c2f-8903-f1be7a262a89"), "خدمات أخرى", "Other services" },
                    { new Guid("94ebb76a-abc3-49a5-85fa-0848e6316e49"), "العناية بالحديقة", "Garden care" },
                    { new Guid("9e9afb05-6d5e-435e-aa16-f818a72acf91"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("aa393aac-dd41-4800-a967-249d18280e3d"), "خدمات حكومية", "Government services" },
                    { new Guid("b6805cd6-a3ce-4792-a1d3-bc41bd11a08d"), "إدارة المكاتب", "Office management" },
                    { new Guid("b88cdfe7-b617-4be9-afd8-a4d3deb377c4"), "رعاية الأطفال", "Childcare" },
                    { new Guid("bbef2711-2d59-4787-9ef9-9720c9d7a974"), "ترفيه", "Entertainment" },
                    { new Guid("c2cd0b51-8068-4359-b65b-c2dc32ec8d87"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("c390ed7c-59b5-4476-ac0e-3cc7811a9ad2"), "الخدمات الطبية", "Medical services" },
                    { new Guid("d23d8f71-8820-4c18-836a-3fe44784e9aa"), "نجارة", "Carpenter " },
                    { new Guid("d522168d-ac80-4312-8d2a-650f7fbdbfa6"), "الرياضة", "Sports" },
                    { new Guid("df3335a7-21f6-4551-bfd4-51f793d13e3a"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("e2a068a0-41cc-491a-b440-07ee5c0a0c5d"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("e40ac36e-9225-4160-8773-46a3e334b834"), "نقاشة", "Painter" },
                    { new Guid("e6216baf-6f8e-4db0-ae22-658d9a6a2c06"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("efdd1287-6673-43cc-b9c0-e76857896937"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("f1d3f296-13d8-4e87-b5d2-7143db1d9071"), "إستشارات", "Consulting " },
                    { new Guid("f43544fc-2d66-445b-86ee-3531bf62d7c3"), "العقارات", "Real estate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d21147c-1a37-4842-b2b2-0b1a9a53db5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "986672e2-f323-4069-91a4-b2b5ad05c76e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b44f5de8-8dc2-4a79-8b1e-20162ea888c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c630f5-59e1-4d2f-b5e0-f22215b86e82");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("012da843-036d-425b-9ac1-41483ea506de"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("04108041-4756-4315-8f58-e9e38f41c7aa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0d30ed1c-f5cb-47dd-9875-d03fc9228a3a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1109ef1a-9be9-4c47-9062-7a0b5c6b7666"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("13f927ac-073f-4c07-b6e3-295b29c4942c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("18313828-660f-4bc3-867b-e7291ef947d2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1ff5168b-0dcf-42a8-b477-2b9c9d6f0cbd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2103215f-a566-44d3-b3f1-712649a3e01f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21f1e211-0762-449d-bbc8-d207157093ea"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("26f6a213-cbef-459f-9176-d32e750571c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2b4ba0e2-1103-44bc-919d-65c2d8fadcff"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2cc58f5f-ecb8-4382-a5c4-d3be96787904"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("392ca14c-0b61-4a81-a4a5-e598a3242f2a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("40abd534-d240-41c4-af90-9fb1ef707da8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("41fac844-d898-4419-8072-2f976fa942b3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("42a2ab89-ecf8-4bc8-80d8-512397bb61da"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("468e09d5-792c-46a7-ae66-ab5b392190de"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4b0b3430-4aad-427e-9b20-923d1b3c83f6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("53d7dc67-3059-476f-b22c-185a8ab12195"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5b0ce8c6-8022-4274-986c-8486148c58d2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5b1b8a00-0d1a-4bfd-b07e-a313f62c6362"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5e194697-a2fd-4b21-9165-c2606ce47239"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("710bf60a-be5b-4a65-afc4-94a110f6d6af"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("732472b5-f1a8-4b5c-b584-75f0e4e4ee4f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("79c9eeb7-9b30-4372-a44c-366704808b2b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7f8517c8-e6fe-491e-9888-fafff45402f8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8112e317-65e6-4b54-a553-ebed21e0d41d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82dd2bd4-41f8-475c-9aac-2e6abdf9837a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("85a86ca2-dbed-4a82-a1f3-987e741ca9b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8c4f7e26-3e20-45f7-89ec-76206b17a3f4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("921d6d51-579a-4c2f-8903-f1be7a262a89"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("94ebb76a-abc3-49a5-85fa-0848e6316e49"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e9afb05-6d5e-435e-aa16-f818a72acf91"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aa393aac-dd41-4800-a967-249d18280e3d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b6805cd6-a3ce-4792-a1d3-bc41bd11a08d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b88cdfe7-b617-4be9-afd8-a4d3deb377c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bbef2711-2d59-4787-9ef9-9720c9d7a974"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c2cd0b51-8068-4359-b65b-c2dc32ec8d87"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c390ed7c-59b5-4476-ac0e-3cc7811a9ad2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d23d8f71-8820-4c18-836a-3fe44784e9aa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d522168d-ac80-4312-8d2a-650f7fbdbfa6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df3335a7-21f6-4551-bfd4-51f793d13e3a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e2a068a0-41cc-491a-b440-07ee5c0a0c5d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e40ac36e-9225-4160-8773-46a3e334b834"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e6216baf-6f8e-4db0-ae22-658d9a6a2c06"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("efdd1287-6673-43cc-b9c0-e76857896937"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f1d3f296-13d8-4e87-b5d2-7143db1d9071"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f43544fc-2d66-445b-86ee-3531bf62d7c3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d4f5563-ff39-4742-a9d4-b58fbef11fe9", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "c4017e06-ea82-4377-8105-dd7c1f02759b", null, "Customer", "CUSTOMER" },
                    { "ed6ccf83-ac28-467b-9e94-c063b1425a6c", null, "Vendor", "VENDOR" },
                    { "fc0745a1-8257-4fb9-9c03-673d5d4d5f35", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("04fcb487-7f14-493c-8147-defdd481c00c"), "نجارة", "Carpenter " },
                    { new Guid("084338ef-fd6d-4e84-b785-61c6ec1b0f9e"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("11dac313-b884-4586-9674-4fff08126bb7"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("15b9eca5-2c6e-4c9d-90d0-0aeaa0140d65"), "كهرباء", "Electricity" },
                    { new Guid("1d493042-6c80-4006-bbf5-d3b90479ed50"), "تسقيف", "Roofing" },
                    { new Guid("1fff2638-7f5d-4f61-a374-7d587dc1261d"), "إدارة المكاتب", "Office management" },
                    { new Guid("216c452a-aa8c-4a73-86d4-88cb6a54f931"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("2855b333-f8af-43ac-9580-7a9227debe83"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("2aaaebc5-852f-48cf-8bbe-49ab312b8e72"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("31b72b47-9851-4790-b417-329d1a9a9417"), "خدمات أخرى", "Other services" },
                    { new Guid("36fc5f12-3f83-47bb-9449-26affe1a7d1a"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("44b98042-c992-410c-8e95-4b34546982e4"), "إستشارات", "Consulting " },
                    { new Guid("50daf00c-2158-4235-ac6c-fd248bd37e7b"), "البناء", "Construction" },
                    { new Guid("5712117a-65ef-450e-b2e6-428228438f69"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("5ea129bc-8bda-4c0b-a2ce-c13295daedd6"), "ضيافة", "Hospitality" },
                    { new Guid("65d2d409-eda1-4670-b10c-53be0167f6f5"), "المحاسبة", "Accounting" },
                    { new Guid("675d1c7d-9518-415c-ae61-380f5d480736"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("70c14eaf-4ad0-4e85-8305-3ea21840a0ad"), "خدمات التجميل", "Beauty services" },
                    { new Guid("70fd11e6-ae7d-488a-8cef-0c33f2db3083"), "خدمات الترجمة", "Translation services" },
                    { new Guid("7d026ce2-f351-4043-8455-bab4689b8620"), "الخدمات الطبية", "Medical services" },
                    { new Guid("824a4ad7-d072-495a-83ff-111eee89e251"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("8427b10a-2776-493c-8646-4ad4d388da7e"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("8bd2d0f2-bfd2-42b1-a26f-c82861c2f7b4"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("96bd8440-5049-49c3-a615-8b514e88a9d5"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("98d12fcb-8dbc-4e8f-a693-719c1c2fbe85"), "العقارات", "Real estate" },
                    { new Guid("9ae5cbfd-7126-4622-8e35-4893e0853ad4"), "الخدمات المالية", "Financial services" },
                    { new Guid("9cc78d9e-ab76-45d6-8954-1f4d49f91c7a"), "الرياضة", "Sports" },
                    { new Guid("ad271563-a20a-47f8-b996-05859518d926"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("b02b95db-fbcb-476c-a91f-bd8e8573a3cd"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("b16ec128-efe0-4ca7-be17-b8d27af7ab01"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("b2aea1c5-56a2-4a13-9be3-698e21daed47"), "نقاشة", "Painter" },
                    { new Guid("b364aaf7-9838-4176-9480-a5c79eb0e2c4"), "سباكة", "Plumbing" },
                    { new Guid("b8339e38-22d6-4276-a7d0-a14a52822e82"), "التكييف", "Air conditioning" },
                    { new Guid("bded84fd-ff0d-477b-a6a9-2bb1765f8d49"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("c18c4bbd-660b-48d0-b9d9-210270eaeb25"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c2968b24-788d-49a4-becc-8ed5f1e57afc"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("c6db9a25-e765-455b-9b4a-0d7fdd3c7dbe"), "خدمات قانونية", "Legal services" },
                    { new Guid("cbc3a2de-f15f-42b8-b609-59380082e218"), "ترفيه", "Entertainment" },
                    { new Guid("cf71277d-589b-449c-912e-ac5d45c13294"), "العناية بالحديقة", "Garden care" },
                    { new Guid("d7745138-55ac-433f-a5bc-f57142e259b1"), "المكتبات", "Libraries" },
                    { new Guid("d77cd269-5831-43a5-8491-1f0aa7ecfa5e"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("da0424c2-ebd0-4f1e-a220-abbbe0309ce5"), "تأمين", "Insurance" },
                    { new Guid("dddab3c6-b092-45a3-8e92-21910f78e6ed"), "رعاية الأطفال", "Childcare" },
                    { new Guid("de18e658-1b3d-415f-be44-f2b74c72835d"), "خدمات حكومية", "Government services" },
                    { new Guid("e5bf3e6f-1c4c-45fe-98ae-dcdcbdb4e29b"), "تقديم الطعام", "Catering " },
                    { new Guid("ecd4cf66-1863-4399-a56d-f4b31889e9fc"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("fb1bb09a-0657-4bb9-9984-e798bc1df72c"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("fc49dcbb-dc7b-4527-a23e-35bb82eb06c4"), "خدمات النقل", "Transportation services" }
                });
        }
    }
}
