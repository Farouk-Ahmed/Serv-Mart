using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestOfferIsDirect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085934cb-3c95-4db0-957d-7fa8570c6111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "476ca221-7b04-4e5f-a7af-f5f10acee850");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa4e6fc0-ec96-443a-b6ab-99890809ec44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e268cf7c-faaa-4566-9d8b-c683622b516c");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("014a18dd-fa01-468a-8146-468d7e3431af"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0206283f-7b84-4f16-9e7c-c9c64962362e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0ae21cb6-7f23-4ec8-b351-121c3088f5e6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("14f3d75b-e137-4049-a2d8-9923d38d44d1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("15d8fc9d-591c-46c2-b6fc-b64d8f8a898b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("185649ec-6f54-4fb4-8d23-585d2369d72a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("261de81b-9266-4a10-beae-95ecb898d0ad"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("28990094-2641-4fee-91c8-5e91298e4091"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2bd9e767-0392-430c-93d7-7cab1ef2fa33"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2cac07d8-b96b-4b69-9978-0b636def252b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2f595b0b-e2dd-4ea0-8ea2-1711f8052154"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3ae75672-c2b3-4821-bd7a-675c17bffcf3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("41bcd345-ef20-43ad-80e6-7d993ab70d14"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("43c4983d-2dde-4e98-8c76-86a1c68d98b3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("548e7ff4-8864-4871-8af0-849ac1696370"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("58d2c3bc-cff6-4ea1-ade4-e1e3293841ce"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6c69e31b-3b53-4540-8b9b-90839b8c8282"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6ea6ba11-3694-4e8e-9578-20f0537ea0f5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82bed89b-644c-4982-85d3-e58a6c6d8a2e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("84493864-65a3-491e-bc78-99f8d11ca15c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a35a161-8b55-4287-a8b6-46f2f70c9956"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9860e731-7256-4aa8-8ee0-3eb71a0e8911"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("98a7bc54-4da2-4c9a-9a95-fc586c7b30d3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9aebbe24-b230-4a03-b99c-f9fc982030c7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9b695490-f804-4138-86ba-6ae81dee7187"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9c2cbc97-b23c-45b2-a99d-478402bf2db1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9fe48952-db55-4ce3-8289-cdb1278de630"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a1e7017f-3e41-452b-be80-b1dbf2a2d119"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a572e35f-fd0f-409a-8c9e-eec9dae68164"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b2926f1f-fd7a-42a1-8b54-011b8c2ba385"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b3a155d1-ebd7-406f-8577-9631003a483b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b4972add-50ff-4239-ad0d-7fd6ced164a9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ba054be1-51bb-4271-8635-4162ba730cf1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bfa6f03a-27a4-429c-a100-f3166713acf2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bfb3351c-6f1d-427a-ac4e-990161f5bf8a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cec4aaa5-1c0f-4f0d-a5eb-8a37942292d8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf7276f8-a4c8-4565-95fb-b71e261942e5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d2bc1e3e-7ca4-41d6-aaf9-75abd6208e30"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d4dab249-b602-4945-ba09-bfb6c0d85ad9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e54d551c-a6ae-4e62-8868-15bbf7651eb2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ecaaff29-dc30-45fd-98d5-0e13cbe42e6b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f3afb60d-071a-4d15-b4ed-fbc5badfbcfc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f5f9e8a7-6e05-4225-ab31-bff61afff360"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f6033852-8aef-4199-a65f-e02452f58b24"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f7c61baf-7011-4956-950c-932c7dc058b4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f82909eb-ad5a-4f08-a471-f95ce8be6e7c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fe3b1978-28a1-4836-9d9f-9d71b8ada892"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fecab93d-6d96-40e1-99c1-dd746b91d9df"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDirect",
                schema: "Request",
                table: "RequestOffer",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IsDirect",
                schema: "Request",
                table: "RequestOffer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "085934cb-3c95-4db0-957d-7fa8570c6111", null, "Vendor", "VENDOR" },
                    { "476ca221-7b04-4e5f-a7af-f5f10acee850", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "aa4e6fc0-ec96-443a-b6ab-99890809ec44", null, "Admin", "ADMIN" },
                    { "e268cf7c-faaa-4566-9d8b-c683622b516c", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("014a18dd-fa01-468a-8146-468d7e3431af"), "إدارة المكاتب", "Office management" },
                    { new Guid("0206283f-7b84-4f16-9e7c-c9c64962362e"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("0ae21cb6-7f23-4ec8-b351-121c3088f5e6"), "خدمات أخرى", "Other services" },
                    { new Guid("14f3d75b-e137-4049-a2d8-9923d38d44d1"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("15d8fc9d-591c-46c2-b6fc-b64d8f8a898b"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("185649ec-6f54-4fb4-8d23-585d2369d72a"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("261de81b-9266-4a10-beae-95ecb898d0ad"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("28990094-2641-4fee-91c8-5e91298e4091"), "خدمات قانونية", "Legal services" },
                    { new Guid("2bd9e767-0392-430c-93d7-7cab1ef2fa33"), "العقارات", "Real estate" },
                    { new Guid("2cac07d8-b96b-4b69-9978-0b636def252b"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("2f595b0b-e2dd-4ea0-8ea2-1711f8052154"), "سباكة", "Plumbing" },
                    { new Guid("3ae75672-c2b3-4821-bd7a-675c17bffcf3"), "المحاسبة", "Accounting" },
                    { new Guid("41bcd345-ef20-43ad-80e6-7d993ab70d14"), "نقاشة", "Painter" },
                    { new Guid("43c4983d-2dde-4e98-8c76-86a1c68d98b3"), "نجارة", "Carpenter " },
                    { new Guid("548e7ff4-8864-4871-8af0-849ac1696370"), "كهرباء", "Electricity" },
                    { new Guid("58d2c3bc-cff6-4ea1-ade4-e1e3293841ce"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("6c69e31b-3b53-4540-8b9b-90839b8c8282"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("6ea6ba11-3694-4e8e-9578-20f0537ea0f5"), "خدمات حكومية", "Government services" },
                    { new Guid("82bed89b-644c-4982-85d3-e58a6c6d8a2e"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("84493864-65a3-491e-bc78-99f8d11ca15c"), "خدمات النقل", "Transportation services" },
                    { new Guid("8a35a161-8b55-4287-a8b6-46f2f70c9956"), "رعاية الأطفال", "Childcare" },
                    { new Guid("9860e731-7256-4aa8-8ee0-3eb71a0e8911"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("98a7bc54-4da2-4c9a-9a95-fc586c7b30d3"), "تأمين", "Insurance" },
                    { new Guid("9aebbe24-b230-4a03-b99c-f9fc982030c7"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("9b695490-f804-4138-86ba-6ae81dee7187"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("9c2cbc97-b23c-45b2-a99d-478402bf2db1"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("9fe48952-db55-4ce3-8289-cdb1278de630"), "المكتبات", "Libraries" },
                    { new Guid("a1e7017f-3e41-452b-be80-b1dbf2a2d119"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("a572e35f-fd0f-409a-8c9e-eec9dae68164"), "الخدمات الطبية", "Medical services" },
                    { new Guid("b2926f1f-fd7a-42a1-8b54-011b8c2ba385"), "التكييف", "Air conditioning" },
                    { new Guid("b3a155d1-ebd7-406f-8577-9631003a483b"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("b4972add-50ff-4239-ad0d-7fd6ced164a9"), "ترفيه", "Entertainment" },
                    { new Guid("ba054be1-51bb-4271-8635-4162ba730cf1"), "خدمات الترجمة", "Translation services" },
                    { new Guid("bfa6f03a-27a4-429c-a100-f3166713acf2"), "العناية بالحديقة", "Garden care" },
                    { new Guid("bfb3351c-6f1d-427a-ac4e-990161f5bf8a"), "البناء", "Construction" },
                    { new Guid("cec4aaa5-1c0f-4f0d-a5eb-8a37942292d8"), "الرياضة", "Sports" },
                    { new Guid("cf7276f8-a4c8-4565-95fb-b71e261942e5"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("d2bc1e3e-7ca4-41d6-aaf9-75abd6208e30"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("d4dab249-b602-4945-ba09-bfb6c0d85ad9"), "تقديم الطعام", "Catering " },
                    { new Guid("e54d551c-a6ae-4e62-8868-15bbf7651eb2"), "الخدمات المالية", "Financial services" },
                    { new Guid("ecaaff29-dc30-45fd-98d5-0e13cbe42e6b"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("f3afb60d-071a-4d15-b4ed-fbc5badfbcfc"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("f5f9e8a7-6e05-4225-ab31-bff61afff360"), "ضيافة", "Hospitality" },
                    { new Guid("f6033852-8aef-4199-a65f-e02452f58b24"), "تسقيف", "Roofing" },
                    { new Guid("f7c61baf-7011-4956-950c-932c7dc058b4"), "إستشارات", "Consulting " },
                    { new Guid("f82909eb-ad5a-4f08-a471-f95ce8be6e7c"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("fe3b1978-28a1-4836-9d9f-9d71b8ada892"), "خدمات التجميل", "Beauty services" },
                    { new Guid("fecab93d-6d96-40e1-99c1-dd746b91d9df"), "ساتلايت ورسيفر", "Satellite and receiver" }
                });
        }
    }
}
