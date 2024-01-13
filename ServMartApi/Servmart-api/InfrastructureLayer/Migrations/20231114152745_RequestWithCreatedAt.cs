using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class RequestWithCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b652571-fbca-4bd7-9451-d9b7da8d1b82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41212653-c824-4192-80b6-527f2c82b9fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "977c2df9-ca72-4d93-a8cf-419bb929df2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9d69cd3-1382-4599-bd37-70224dff33be");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("04c1b356-86fe-417f-a8f3-d45a0a9ec0a4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("09dc6e0c-4e58-4d19-96ad-de56e1f948d3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0e0d3d57-707e-40ef-9b5b-d91a7469a8cf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0fe0d8b3-48a0-437f-8c17-0b12133d2662"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("13215c2c-0729-49d6-b886-3e5af13a9f35"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("13eff659-401c-49f1-8c65-4f34ebab2c71"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1422e84b-e960-45ee-99bf-87414908b320"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1799a0e8-c8f8-4802-b072-9579f10ecaac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1b15763d-f675-4e82-9892-24b87b357a96"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("224fe805-2674-473c-b6bf-daa114433677"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2d2e4910-0c42-4f52-adf6-7155b25902a5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("33dd5aac-6159-4d18-b50f-1e20acc38187"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("417700ec-58ab-4d1c-9cbd-9ca66f3356d9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("457a7b9f-5f46-4bec-983f-fcbe8990ed7b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("50be5f81-2c60-4d74-be74-9833855835be"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("52e20fce-cfdf-43a4-92d1-680dbb42be41"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("54222aed-8a65-4257-b828-8e35caa7c8fb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57989f36-dac6-44af-a1af-a761123b04e5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5ac1710c-410f-4544-bf05-ca4240737a55"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5b19736b-9339-4e22-9524-96e641450596"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("61576858-214a-43f4-b466-53ee97b4cb37"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("61e1b5ff-21da-4107-88c3-c9b60f1c29c8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("669891fc-4f30-4eb2-af5a-a35571f43746"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7152529e-db32-4cb8-94ad-b560f05ba3db"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7328fe83-e7e4-438e-a17f-eb6da724a168"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8055c5a6-5c79-4113-ba78-cb1f595c960d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("83d582b4-21fc-4fb9-99f7-82049c96c0db"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("84377ebf-83e2-47eb-a0ab-b3708532a777"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87a15a14-efcb-4d6b-bc38-be97e0f5aa69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a4ecb40-8014-4e42-8a6f-40b720e5038d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a85f03c-8806-417c-8533-2152b58fadac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ac4a777f-ae04-4f33-a4d1-8a5bcd4b5eda"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("af4b29ff-ad7d-4872-bcfc-9f4b3e049e8b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("af50fab6-5cfa-4e94-bcd2-d839b096592c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b51e8339-f535-4eeb-aaaf-3ed8d2840167"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c3e9a3c6-4832-467f-a808-b6cf611ac461"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c802fea4-15d0-46bf-b763-d778886c1a2d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d24f5e8c-667e-40e4-a010-6c5736fbced2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d2b569b5-4e52-4d58-b918-3c34a1f08b9d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d6856632-ed51-4889-ab90-ffaba6d9d78c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d788b2f2-4599-47a6-b33f-3fba785843e6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e2107a40-69f3-44a4-b7e0-01c37fa9a71d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e6e5d709-3423-4184-ac1e-45b4cccf294e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ea851fe4-b117-40d3-918c-9bd9c6a9836e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fa786bf1-7daa-41c3-8f60-1ae7272c8dba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc045868-ddd4-445b-8c54-89e472418efc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ff49ac16-1d18-4491-bb03-a90c797055d5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ffb7c94f-ab0e-41b3-9882-f329560b6388"));

            migrationBuilder.DropColumn(
                name: "EndDate",
                schema: "Request",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                schema: "Request",
                table: "Request",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                schema: "Request",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3804066a-8b89-4c4f-87df-fd6aaccc52e9", null, "Vendor", "VENDOR" },
                    { "43decfa9-e3c4-4968-ac1a-fbca3a314e97", null, "Admin", "ADMIN" },
                    { "66d4eb80-2196-4cff-b0bf-8d6cb88825a2", null, "Customer", "CUSTOMER" },
                    { "eadcf9f0-75e8-4981-b3ef-91c19756ff42", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("054f148b-f838-4732-9de2-bcc7d91aa473"), "خدمات حكومية", "Government services" },
                    { new Guid("0ba193d8-eda2-488c-ab2c-b1a60ff98f35"), "ترفيه", "Entertainment" },
                    { new Guid("1622e8d8-3b3b-46c9-8663-2c9b8037441b"), "ضيافة", "Hospitality" },
                    { new Guid("196f94b1-a789-4cbf-af4d-ec0e0fc4da73"), "رعاية الأطفال", "Childcare" },
                    { new Guid("1a9d8b31-899e-42ac-b4ab-1734be6a3002"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("22b6eb9b-58bf-409f-bd8c-04ae0706fcc5"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("27329da7-7461-45fb-92e0-6e655f4f0fe3"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("278326ec-1c30-404e-ad56-5604a1dc4c27"), "المحاسبة", "Accounting" },
                    { new Guid("2864443b-b5b5-43e2-85a8-2c15d4362c3b"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("29cd209d-1b42-4933-bd5d-9845bb8a6730"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("29ec9b10-0e6a-491a-8dd5-5294f47ed508"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("2cd8bb2b-a9e7-4592-9a4d-70ecd752ec73"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("2d2df455-be9f-4479-b21d-78e07ba4235b"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("2d3e0ced-df00-47df-8ac6-eb96477a1903"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("32f97b4e-997b-42a5-9b4d-86f921f43ba2"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("3b2bf177-0142-42ed-b407-01ced9f05a0f"), "خدمات أخرى", "Other services" },
                    { new Guid("3d4643c7-4051-42bc-b372-05b280dff04f"), "نقاشة", "Painter" },
                    { new Guid("41f6b5c1-b8b2-411a-8080-7473ddbe6911"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("460990a0-c9d9-46f1-888d-dc6a7bb8dc3b"), "الخدمات الطبية", "Medical services" },
                    { new Guid("48e542df-ad0c-4fbb-b82f-14800983af81"), "العناية بالحديقة", "Garden care" },
                    { new Guid("51c8ec4d-0705-46f2-ba5e-03fd767b46af"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("63019f1f-550a-42d5-a41d-6c4bedf4d9ee"), "إدارة المكاتب", "Office management" },
                    { new Guid("65273839-e0cb-44e7-b7ea-67cffe0ea030"), "الرياضة", "Sports" },
                    { new Guid("7ab2e85a-502f-42c1-bf0a-43d2c6773130"), "سباكة", "Plumbing" },
                    { new Guid("7c5640d9-f3ff-477a-8348-6682eec1a3b8"), "البناء", "Construction" },
                    { new Guid("804d90de-7c04-4503-8bbf-53093510bf8f"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("885e2ea7-4ed4-438f-a3c6-b0e0aee3a4fe"), "خدمات قانونية", "Legal services" },
                    { new Guid("955bd1bf-b437-4ffa-a316-ab2519d47d12"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("98831f1c-34ad-4b21-b6a3-b1016ae8fcbd"), "العقارات", "Real estate" },
                    { new Guid("99948c39-9b88-4cba-8012-fb727d485173"), "إستشارات", "Consulting " },
                    { new Guid("9aa9f0f6-d2e7-4965-9549-8fdbd62d61cb"), "خدمات النقل", "Transportation services" },
                    { new Guid("9bd85579-7d18-4111-8d7e-b9227bbddb95"), "نجارة", "Carpenter " },
                    { new Guid("a0c47d73-742f-4683-a2ff-67f2f5383953"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("a2483bdd-8157-4e93-85ee-c230a847f231"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("a27768ca-e8f4-4a7e-a429-1c02a8cd6281"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("aeed867e-ec87-4bfa-9ccf-82f1b35ea28a"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("bb057a55-fdde-4ca3-a424-050623a8c760"), "خدمات التجميل", "Beauty services" },
                    { new Guid("bb4995d3-5d50-4098-b914-ce0c21709094"), "كهرباء", "Electricity" },
                    { new Guid("bc6af618-ee2c-4e33-86ca-6821cce523ab"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("c448c2d8-5814-4e41-abd8-f01f327923d3"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("c86545e4-dae8-4e43-8872-cc6f5a97e2b7"), "الخدمات المالية", "Financial services" },
                    { new Guid("dbb1141b-d858-4782-8232-014779be5d11"), "المكتبات", "Libraries" },
                    { new Guid("de44bd79-4fc4-4d1a-a01f-5349e7bb09d9"), "خدمات الترجمة", "Translation services" },
                    { new Guid("e4b334fe-0853-4ac5-981a-8848d4577b76"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("f436968f-d824-4140-be3b-f9f5ac7f9076"), "تسقيف", "Roofing" },
                    { new Guid("f5796197-4e85-492f-aaa1-b9028f73dd27"), "التكييف", "Air conditioning" },
                    { new Guid("f9c54ae6-1b4c-4581-93f7-fbcd8d3a68c7"), "تقديم الطعام", "Catering " },
                    { new Guid("fa4940bc-4bc5-4bbe-9589-146220e1a9f6"), "تأمين", "Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3804066a-8b89-4c4f-87df-fd6aaccc52e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43decfa9-e3c4-4968-ac1a-fbca3a314e97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d4eb80-2196-4cff-b0bf-8d6cb88825a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eadcf9f0-75e8-4981-b3ef-91c19756ff42");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("054f148b-f838-4732-9de2-bcc7d91aa473"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0ba193d8-eda2-488c-ab2c-b1a60ff98f35"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1622e8d8-3b3b-46c9-8663-2c9b8037441b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("196f94b1-a789-4cbf-af4d-ec0e0fc4da73"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a9d8b31-899e-42ac-b4ab-1734be6a3002"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("22b6eb9b-58bf-409f-bd8c-04ae0706fcc5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("27329da7-7461-45fb-92e0-6e655f4f0fe3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("278326ec-1c30-404e-ad56-5604a1dc4c27"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2864443b-b5b5-43e2-85a8-2c15d4362c3b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("29cd209d-1b42-4933-bd5d-9845bb8a6730"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("29ec9b10-0e6a-491a-8dd5-5294f47ed508"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2cd8bb2b-a9e7-4592-9a4d-70ecd752ec73"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2d2df455-be9f-4479-b21d-78e07ba4235b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2d3e0ced-df00-47df-8ac6-eb96477a1903"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("32f97b4e-997b-42a5-9b4d-86f921f43ba2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3b2bf177-0142-42ed-b407-01ced9f05a0f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3d4643c7-4051-42bc-b372-05b280dff04f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("41f6b5c1-b8b2-411a-8080-7473ddbe6911"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("460990a0-c9d9-46f1-888d-dc6a7bb8dc3b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("48e542df-ad0c-4fbb-b82f-14800983af81"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("51c8ec4d-0705-46f2-ba5e-03fd767b46af"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("63019f1f-550a-42d5-a41d-6c4bedf4d9ee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("65273839-e0cb-44e7-b7ea-67cffe0ea030"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7ab2e85a-502f-42c1-bf0a-43d2c6773130"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7c5640d9-f3ff-477a-8348-6682eec1a3b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("804d90de-7c04-4503-8bbf-53093510bf8f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("885e2ea7-4ed4-438f-a3c6-b0e0aee3a4fe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("955bd1bf-b437-4ffa-a316-ab2519d47d12"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("98831f1c-34ad-4b21-b6a3-b1016ae8fcbd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("99948c39-9b88-4cba-8012-fb727d485173"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9aa9f0f6-d2e7-4965-9549-8fdbd62d61cb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9bd85579-7d18-4111-8d7e-b9227bbddb95"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a0c47d73-742f-4683-a2ff-67f2f5383953"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a2483bdd-8157-4e93-85ee-c230a847f231"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a27768ca-e8f4-4a7e-a429-1c02a8cd6281"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aeed867e-ec87-4bfa-9ccf-82f1b35ea28a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bb057a55-fdde-4ca3-a424-050623a8c760"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bb4995d3-5d50-4098-b914-ce0c21709094"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bc6af618-ee2c-4e33-86ca-6821cce523ab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c448c2d8-5814-4e41-abd8-f01f327923d3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c86545e4-dae8-4e43-8872-cc6f5a97e2b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dbb1141b-d858-4782-8232-014779be5d11"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de44bd79-4fc4-4d1a-a01f-5349e7bb09d9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e4b334fe-0853-4ac5-981a-8848d4577b76"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f436968f-d824-4140-be3b-f9f5ac7f9076"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f5796197-4e85-492f-aaa1-b9028f73dd27"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f9c54ae6-1b4c-4581-93f7-fbcd8d3a68c7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fa4940bc-4bc5-4bbe-9589-146220e1a9f6"));

            migrationBuilder.DropColumn(
                name: "Duration",
                schema: "Request",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "Request",
                table: "Request",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                schema: "Request",
                table: "Request",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b652571-fbca-4bd7-9451-d9b7da8d1b82", null, "Admin", "ADMIN" },
                    { "41212653-c824-4192-80b6-527f2c82b9fe", null, "Customer", "CUSTOMER" },
                    { "977c2df9-ca72-4d93-a8cf-419bb929df2d", null, "Vendor", "VENDOR" },
                    { "e9d69cd3-1382-4599-bd37-70224dff33be", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("04c1b356-86fe-417f-a8f3-d45a0a9ec0a4"), "خدمات حكومية", "Government services" },
                    { new Guid("09dc6e0c-4e58-4d19-96ad-de56e1f948d3"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("0e0d3d57-707e-40ef-9b5b-d91a7469a8cf"), "نجارة", "Carpenter " },
                    { new Guid("0fe0d8b3-48a0-437f-8c17-0b12133d2662"), "إدارة المكاتب", "Office management" },
                    { new Guid("13215c2c-0729-49d6-b886-3e5af13a9f35"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("13eff659-401c-49f1-8c65-4f34ebab2c71"), "خدمات أخرى", "Other services" },
                    { new Guid("1422e84b-e960-45ee-99bf-87414908b320"), "خدمات الترجمة", "Translation services" },
                    { new Guid("1799a0e8-c8f8-4802-b072-9579f10ecaac"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("1b15763d-f675-4e82-9892-24b87b357a96"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("224fe805-2674-473c-b6bf-daa114433677"), "سباكة", "Plumbing" },
                    { new Guid("2d2e4910-0c42-4f52-adf6-7155b25902a5"), "كهرباء", "Electricity" },
                    { new Guid("33dd5aac-6159-4d18-b50f-1e20acc38187"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("417700ec-58ab-4d1c-9cbd-9ca66f3356d9"), "تأمين", "Insurance" },
                    { new Guid("457a7b9f-5f46-4bec-983f-fcbe8990ed7b"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("50be5f81-2c60-4d74-be74-9833855835be"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("52e20fce-cfdf-43a4-92d1-680dbb42be41"), "العناية بالحديقة", "Garden care" },
                    { new Guid("54222aed-8a65-4257-b828-8e35caa7c8fb"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("57989f36-dac6-44af-a1af-a761123b04e5"), "خدمات قانونية", "Legal services" },
                    { new Guid("5ac1710c-410f-4544-bf05-ca4240737a55"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("5b19736b-9339-4e22-9524-96e641450596"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("61576858-214a-43f4-b466-53ee97b4cb37"), "إستشارات", "Consulting " },
                    { new Guid("61e1b5ff-21da-4107-88c3-c9b60f1c29c8"), "خدمات التجميل", "Beauty services" },
                    { new Guid("669891fc-4f30-4eb2-af5a-a35571f43746"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("7152529e-db32-4cb8-94ad-b560f05ba3db"), "الخدمات الطبية", "Medical services" },
                    { new Guid("7328fe83-e7e4-438e-a17f-eb6da724a168"), "المحاسبة", "Accounting" },
                    { new Guid("8055c5a6-5c79-4113-ba78-cb1f595c960d"), "نقاشة", "Painter" },
                    { new Guid("83d582b4-21fc-4fb9-99f7-82049c96c0db"), "البناء", "Construction" },
                    { new Guid("84377ebf-83e2-47eb-a0ab-b3708532a777"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("87a15a14-efcb-4d6b-bc38-be97e0f5aa69"), "التكييف", "Air conditioning" },
                    { new Guid("8a4ecb40-8014-4e42-8a6f-40b720e5038d"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("8a85f03c-8806-417c-8533-2152b58fadac"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("ac4a777f-ae04-4f33-a4d1-8a5bcd4b5eda"), "الرياضة", "Sports" },
                    { new Guid("af4b29ff-ad7d-4872-bcfc-9f4b3e049e8b"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("af50fab6-5cfa-4e94-bcd2-d839b096592c"), "العقارات", "Real estate" },
                    { new Guid("b51e8339-f535-4eeb-aaaf-3ed8d2840167"), "المكتبات", "Libraries" },
                    { new Guid("c3e9a3c6-4832-467f-a808-b6cf611ac461"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c802fea4-15d0-46bf-b763-d778886c1a2d"), "ضيافة", "Hospitality" },
                    { new Guid("d24f5e8c-667e-40e4-a010-6c5736fbced2"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("d2b569b5-4e52-4d58-b918-3c34a1f08b9d"), "تقديم الطعام", "Catering " },
                    { new Guid("d6856632-ed51-4889-ab90-ffaba6d9d78c"), "الخدمات المالية", "Financial services" },
                    { new Guid("d788b2f2-4599-47a6-b33f-3fba785843e6"), "تسقيف", "Roofing" },
                    { new Guid("e2107a40-69f3-44a4-b7e0-01c37fa9a71d"), "خدمات النقل", "Transportation services" },
                    { new Guid("e6e5d709-3423-4184-ac1e-45b4cccf294e"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("ea851fe4-b117-40d3-918c-9bd9c6a9836e"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("fa786bf1-7daa-41c3-8f60-1ae7272c8dba"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("fc045868-ddd4-445b-8c54-89e472418efc"), "رعاية الأطفال", "Childcare" },
                    { new Guid("ff49ac16-1d18-4491-bb03-a90c797055d5"), "ترفيه", "Entertainment" },
                    { new Guid("ffb7c94f-ab0e-41b3-9882-f329560b6388"), "تدريب اللياقة البدنية", "Fitness training" }
                });
        }
    }
}
