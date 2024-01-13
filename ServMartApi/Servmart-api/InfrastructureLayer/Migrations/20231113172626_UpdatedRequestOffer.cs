using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceMedia_Service_ServiceID",
                schema: "Service",
                table: "ServiceMedia");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f6404ae-3362-487b-a2ce-c5c67b795f91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a9a37ee-347d-4fdd-a1c4-77352182dd11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "661f57df-d50f-4034-aa87-6bc0829cf667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a6f241-12b1-423d-95be-ab4e0d327bc7");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0424a710-cb80-4a0b-bdd8-9a61a7622f86"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0795aff2-73bc-4542-bdbf-eab436a98bac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1aea3da0-bef9-46e2-a624-0e224d70fa8b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1c5615e4-c005-46ef-b100-b289a4638b3a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21c9c8bc-eee9-4c10-8c2d-6304dbdba63d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("281397d6-0b07-41d6-b26b-e4c3cf81cec5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2e62c9a2-cdb5-4bf9-9098-b5c0521a41c6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ebe07d1-7e56-4d85-bfdc-24396cc7796b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2fb55c30-a4f4-432e-9da3-f80dd1fa2854"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3103ffd1-520f-4d15-a07b-4442fe84c7f4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("31b6e294-28ef-404d-8315-ed63d4f31fc7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("32706a9a-9bb9-4830-8249-0428d76e852f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("344d6c7d-7dbc-48a5-9250-eb95c3a540d1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("362043f3-4439-4564-ae88-ec65ae716004"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3bcab41c-db35-4ed0-a054-50afb5e30ff6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e11eb23-5e57-4bb3-bcab-fe851aaf2a6e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6378dfc0-72d3-49f2-a56d-8ff9f2bf6079"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("63ffa90c-ae1f-4274-a3db-0be7f8d3f974"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6503c8d5-77d1-48ff-b060-2694e96683e6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6d5c2de4-3192-4681-b320-96c1b64cb326"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("725ae7ed-49c9-4243-8a5f-0a79b224608c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7267cf2e-09a0-4c00-83c4-015bf87ed2ed"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7f4f7877-1bd4-44ab-afe3-1b576e960638"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("85e8eed0-3626-41c5-8cb0-84052f51b31d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8cb2285e-618f-4494-853e-e93f9dae42d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8ced543c-a049-457e-9032-811fcccb5a69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8f07b8e8-0c1e-4204-98f6-4458a1c2832f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9249f611-f473-4e3b-879f-608f39bf7c62"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9531ff3e-8b38-4ae7-9481-9d1ac4d9940e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("973db0a6-5078-48fa-b111-da6fdb28914b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9ac07845-e55d-4c69-8fbc-486ef8e30c7d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9afc7081-3e5c-4a81-8887-6b6ed050e433"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a469b571-eee3-47f1-94cb-aa60fb76e339"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b137b664-b358-4aba-8149-3c3c5273ea77"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b21c75ce-3860-46f5-b2ac-28f308ab344a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b9ea6a34-37d9-4e19-b74d-c21c7ef3bccb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ba6fbd78-b016-4679-b8cc-212eec6ffb75"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("be02352c-bc95-406b-b1d3-e0dc5510c6ee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c841fd75-bcb0-426d-97b2-e78e23bc9eba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cbeeb638-bf68-478e-b26c-b1dcad48bc3a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d2c84016-2e22-4657-94cb-bf734ebfcf18"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d5b8a086-e5e4-4b7d-82b4-8e4b5a8c44e9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("db5ecc40-a259-49f9-940f-a34fc823ae4a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dcf1a12a-f935-40ee-b852-ffe538ccd470"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e59b4d36-f506-40c0-90f3-875355904cab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e796d4ff-3ea9-4f7b-be47-997e1c88c687"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ef053846-3143-4a08-8461-f1e242ff9c12"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fd878e7f-5afa-468f-ae80-5146a0216463"));

            migrationBuilder.DropColumn(
                name: "EndDate",
                schema: "Request",
                table: "RequestOffer");

            migrationBuilder.RenameColumn(
                name: "State",
                schema: "Request",
                table: "RequestOffer",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                schema: "Request",
                table: "RequestOffer",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                schema: "Request",
                table: "RequestOffer",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceMedia_Service_ServiceID",
                schema: "Service",
                table: "ServiceMedia",
                column: "ServiceID",
                principalSchema: "Service",
                principalTable: "Service",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceMedia_Service_ServiceID",
                schema: "Service",
                table: "ServiceMedia");

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

            migrationBuilder.DropColumn(
                name: "Duration",
                schema: "Request",
                table: "RequestOffer");

            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "Request",
                table: "RequestOffer",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "Request",
                table: "RequestOffer",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                schema: "Request",
                table: "RequestOffer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f6404ae-3362-487b-a2ce-c5c67b795f91", null, "Admin", "ADMIN" },
                    { "5a9a37ee-347d-4fdd-a1c4-77352182dd11", null, "Vendor", "VENDOR" },
                    { "661f57df-d50f-4034-aa87-6bc0829cf667", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "e0a6f241-12b1-423d-95be-ab4e0d327bc7", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0424a710-cb80-4a0b-bdd8-9a61a7622f86"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("0795aff2-73bc-4542-bdbf-eab436a98bac"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("1aea3da0-bef9-46e2-a624-0e224d70fa8b"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("1c5615e4-c005-46ef-b100-b289a4638b3a"), "العناية بالحديقة", "Garden care" },
                    { new Guid("21c9c8bc-eee9-4c10-8c2d-6304dbdba63d"), "تقديم الطعام", "Catering " },
                    { new Guid("281397d6-0b07-41d6-b26b-e4c3cf81cec5"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("2e62c9a2-cdb5-4bf9-9098-b5c0521a41c6"), "سباكة", "Plumbing" },
                    { new Guid("2ebe07d1-7e56-4d85-bfdc-24396cc7796b"), "خدمات حكومية", "Government services" },
                    { new Guid("2fb55c30-a4f4-432e-9da3-f80dd1fa2854"), "الرياضة", "Sports" },
                    { new Guid("3103ffd1-520f-4d15-a07b-4442fe84c7f4"), "إستشارات", "Consulting " },
                    { new Guid("31b6e294-28ef-404d-8315-ed63d4f31fc7"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("32706a9a-9bb9-4830-8249-0428d76e852f"), "ضيافة", "Hospitality" },
                    { new Guid("344d6c7d-7dbc-48a5-9250-eb95c3a540d1"), "إدارة المكاتب", "Office management" },
                    { new Guid("362043f3-4439-4564-ae88-ec65ae716004"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("3bcab41c-db35-4ed0-a054-50afb5e30ff6"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("4e11eb23-5e57-4bb3-bcab-fe851aaf2a6e"), "المكتبات", "Libraries" },
                    { new Guid("6378dfc0-72d3-49f2-a56d-8ff9f2bf6079"), "رعاية الأطفال", "Childcare" },
                    { new Guid("63ffa90c-ae1f-4274-a3db-0be7f8d3f974"), "خدمات أخرى", "Other services" },
                    { new Guid("6503c8d5-77d1-48ff-b060-2694e96683e6"), "خدمات الترجمة", "Translation services" },
                    { new Guid("6d5c2de4-3192-4681-b320-96c1b64cb326"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("725ae7ed-49c9-4243-8a5f-0a79b224608c"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("7267cf2e-09a0-4c00-83c4-015bf87ed2ed"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("7f4f7877-1bd4-44ab-afe3-1b576e960638"), "كهرباء", "Electricity" },
                    { new Guid("85e8eed0-3626-41c5-8cb0-84052f51b31d"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("8cb2285e-618f-4494-853e-e93f9dae42d0"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("8ced543c-a049-457e-9032-811fcccb5a69"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("8f07b8e8-0c1e-4204-98f6-4458a1c2832f"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("9249f611-f473-4e3b-879f-608f39bf7c62"), "العقارات", "Real estate" },
                    { new Guid("9531ff3e-8b38-4ae7-9481-9d1ac4d9940e"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("973db0a6-5078-48fa-b111-da6fdb28914b"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("9ac07845-e55d-4c69-8fbc-486ef8e30c7d"), "الخدمات الطبية", "Medical services" },
                    { new Guid("9afc7081-3e5c-4a81-8887-6b6ed050e433"), "تأمين", "Insurance" },
                    { new Guid("a469b571-eee3-47f1-94cb-aa60fb76e339"), "خدمات قانونية", "Legal services" },
                    { new Guid("b137b664-b358-4aba-8149-3c3c5273ea77"), "تسقيف", "Roofing" },
                    { new Guid("b21c75ce-3860-46f5-b2ac-28f308ab344a"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("b9ea6a34-37d9-4e19-b74d-c21c7ef3bccb"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("ba6fbd78-b016-4679-b8cc-212eec6ffb75"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("be02352c-bc95-406b-b1d3-e0dc5510c6ee"), "نقاشة", "Painter" },
                    { new Guid("c841fd75-bcb0-426d-97b2-e78e23bc9eba"), "التكييف", "Air conditioning" },
                    { new Guid("cbeeb638-bf68-478e-b26c-b1dcad48bc3a"), "البناء", "Construction" },
                    { new Guid("d2c84016-2e22-4657-94cb-bf734ebfcf18"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("d5b8a086-e5e4-4b7d-82b4-8e4b5a8c44e9"), "ترفيه", "Entertainment" },
                    { new Guid("db5ecc40-a259-49f9-940f-a34fc823ae4a"), "خدمات التجميل", "Beauty services" },
                    { new Guid("dcf1a12a-f935-40ee-b852-ffe538ccd470"), "نجارة", "Carpenter " },
                    { new Guid("e59b4d36-f506-40c0-90f3-875355904cab"), "الخدمات المالية", "Financial services" },
                    { new Guid("e796d4ff-3ea9-4f7b-be47-997e1c88c687"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("ef053846-3143-4a08-8461-f1e242ff9c12"), "خدمات النقل", "Transportation services" },
                    { new Guid("fd878e7f-5afa-468f-ae80-5146a0216463"), "المحاسبة", "Accounting" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceMedia_Service_ServiceID",
                schema: "Service",
                table: "ServiceMedia",
                column: "ServiceID",
                principalSchema: "Service",
                principalTable: "Service",
                principalColumn: "ID");
        }
    }
}
