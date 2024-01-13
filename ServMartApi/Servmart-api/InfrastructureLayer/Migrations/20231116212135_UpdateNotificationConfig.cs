using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNotificationConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "1f41b92a-902b-4245-89bf-708f5e3224c3", null, "Customer", "CUSTOMER" },
                    { "96600e49-9882-4e8d-b026-249114e2825c", null, "Vendor", "VENDOR" },
                    { "bc82628a-84ec-4ba4-a2f5-21fa8d86c9c8", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "e3144f1a-f3f8-4179-af86-a424667769b2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("07101d31-61b8-49d6-b4cb-ad978fd8bb8d"), "خدمات حكومية", "Government services" },
                    { new Guid("08a2a1d5-2328-4e3b-9df2-4607d9eef627"), "خدمات الترجمة", "Translation services" },
                    { new Guid("090ac529-fe5d-4e32-a556-d000ed8c47ba"), "الخدمات الطبية", "Medical services" },
                    { new Guid("09f19426-31f2-4eba-b06a-bc693172a0e1"), "سباكة", "Plumbing" },
                    { new Guid("10cd6e40-7fcb-4828-87c7-2158b42c012a"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("16c12d0d-e628-4537-8dd9-8c04777c1b04"), "خدمات التجميل", "Beauty services" },
                    { new Guid("1e109557-a1de-450b-b2da-ddf6583274cd"), "تقديم الطعام", "Catering " },
                    { new Guid("21ee11e5-1dd7-4e34-9ba4-d57838404863"), "إستشارات", "Consulting " },
                    { new Guid("234af348-feaf-434b-821e-9fa3fe332b50"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("2ea91942-75b9-4866-9ab6-94f70e042bf0"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("3506c448-ff02-4168-9ed5-4f0805e89770"), "المحاسبة", "Accounting" },
                    { new Guid("3bd82edd-ad85-4824-998d-95d1a1298ca9"), "تأمين", "Insurance" },
                    { new Guid("3cb143e8-ee7a-4be5-8d87-57788e88b147"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("3e71d3ba-39e4-49d1-95f3-c52b628e5133"), "كهرباء", "Electricity" },
                    { new Guid("426aff11-7dc8-4f32-98e7-f37dbea920d1"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("43f3a438-e558-4d6f-b6d8-6642ae03e910"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("45c34d8c-d4b7-402e-ba0b-09ac4ed35ef7"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("4d9d0c66-6c7b-42cd-b19c-a0798ee08d8d"), "العناية بالحديقة", "Garden care" },
                    { new Guid("4e025ea1-bda6-4c62-a411-95b7732ba669"), "ترفيه", "Entertainment" },
                    { new Guid("57a85d43-31be-4610-b28a-da2a03d044d0"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("5e79f60e-26e7-4e5c-9bcd-7ffcf165791a"), "خدمات النقل", "Transportation services" },
                    { new Guid("5f3257f8-5d24-4e9f-a4b5-20a397665f33"), "خدمات قانونية", "Legal services" },
                    { new Guid("67b8389b-8888-44a0-9875-3697a4fe37ae"), "نقاشة", "Painter" },
                    { new Guid("67e8563a-9643-46bc-9c5a-d380eb9d9003"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("7de9a5f6-ef39-4f9a-9df7-3b33e56c6c27"), "التكييف", "Air conditioning" },
                    { new Guid("7fe14dfd-841a-42b5-9a28-8f336f685020"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("82630ebd-3bcc-4b37-aaf4-797662897f3e"), "خدمات أخرى", "Other services" },
                    { new Guid("95b7d412-cb83-4b53-95c8-52a5c0cf6b79"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("9654b5ea-e975-435c-a452-46a14e19de4e"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("97e5dc3d-5c47-42d3-9c3b-e0086427ebef"), "البناء", "Construction" },
                    { new Guid("a45f2529-1098-4889-af66-50e0fab08541"), "الخدمات المالية", "Financial services" },
                    { new Guid("a8c9fd62-e468-4597-9ddb-55e9adc56e34"), "إدارة المكاتب", "Office management" },
                    { new Guid("a9b04243-f86b-4346-8538-03efc8cb534c"), "نجارة", "Carpenter " },
                    { new Guid("ad612b1e-91ea-4373-bb6f-18f5afc17e3c"), "ضيافة", "Hospitality" },
                    { new Guid("aea22b8e-35fe-4c30-9a2e-4f3278965e2e"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("b2563916-4047-4024-aa25-500e25898906"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("b5079ae7-c376-4ea9-a400-f7a0abd7720e"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("c5b6e93e-9cba-4299-a777-4241f8713c37"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c9e94ff0-4651-4f02-962a-1d870c61fca4"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("cbfc51e1-f53f-48a7-ab87-5835c58f5067"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("cd39b9f6-43b2-48a2-b85b-c9418a598fa6"), "العقارات", "Real estate" },
                    { new Guid("e4a1621c-15e4-4d8c-9b5c-eb05be65501e"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("e8a17c37-4dd4-427d-b681-4002019b347a"), "الرياضة", "Sports" },
                    { new Guid("ebfed259-0c6f-4486-b2fe-dbf9edf1be7e"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("f7a0beb7-82c1-4d57-a784-d83235e63849"), "تسقيف", "Roofing" },
                    { new Guid("fa8d5f83-b455-40c5-9fdc-33314b6ad664"), "رعاية الأطفال", "Childcare" },
                    { new Guid("fc4631f5-c6d3-462a-966e-cceafa83b687"), "المكتبات", "Libraries" },
                    { new Guid("fd4bb0dd-7cba-4c12-8bbb-18f47320bc05"), "توصيل طلبات الطعام", "Food delivery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f41b92a-902b-4245-89bf-708f5e3224c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96600e49-9882-4e8d-b026-249114e2825c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc82628a-84ec-4ba4-a2f5-21fa8d86c9c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3144f1a-f3f8-4179-af86-a424667769b2");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("07101d31-61b8-49d6-b4cb-ad978fd8bb8d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("08a2a1d5-2328-4e3b-9df2-4607d9eef627"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("090ac529-fe5d-4e32-a556-d000ed8c47ba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("09f19426-31f2-4eba-b06a-bc693172a0e1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("10cd6e40-7fcb-4828-87c7-2158b42c012a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("16c12d0d-e628-4537-8dd9-8c04777c1b04"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e109557-a1de-450b-b2da-ddf6583274cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21ee11e5-1dd7-4e34-9ba4-d57838404863"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("234af348-feaf-434b-821e-9fa3fe332b50"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ea91942-75b9-4866-9ab6-94f70e042bf0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3506c448-ff02-4168-9ed5-4f0805e89770"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3bd82edd-ad85-4824-998d-95d1a1298ca9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3cb143e8-ee7a-4be5-8d87-57788e88b147"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3e71d3ba-39e4-49d1-95f3-c52b628e5133"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("426aff11-7dc8-4f32-98e7-f37dbea920d1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("43f3a438-e558-4d6f-b6d8-6642ae03e910"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("45c34d8c-d4b7-402e-ba0b-09ac4ed35ef7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4d9d0c66-6c7b-42cd-b19c-a0798ee08d8d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e025ea1-bda6-4c62-a411-95b7732ba669"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57a85d43-31be-4610-b28a-da2a03d044d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5e79f60e-26e7-4e5c-9bcd-7ffcf165791a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5f3257f8-5d24-4e9f-a4b5-20a397665f33"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67b8389b-8888-44a0-9875-3697a4fe37ae"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67e8563a-9643-46bc-9c5a-d380eb9d9003"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7de9a5f6-ef39-4f9a-9df7-3b33e56c6c27"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7fe14dfd-841a-42b5-9a28-8f336f685020"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82630ebd-3bcc-4b37-aaf4-797662897f3e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95b7d412-cb83-4b53-95c8-52a5c0cf6b79"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9654b5ea-e975-435c-a452-46a14e19de4e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("97e5dc3d-5c47-42d3-9c3b-e0086427ebef"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a45f2529-1098-4889-af66-50e0fab08541"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a8c9fd62-e468-4597-9ddb-55e9adc56e34"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a9b04243-f86b-4346-8538-03efc8cb534c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad612b1e-91ea-4373-bb6f-18f5afc17e3c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aea22b8e-35fe-4c30-9a2e-4f3278965e2e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b2563916-4047-4024-aa25-500e25898906"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b5079ae7-c376-4ea9-a400-f7a0abd7720e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c5b6e93e-9cba-4299-a777-4241f8713c37"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c9e94ff0-4651-4f02-962a-1d870c61fca4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cbfc51e1-f53f-48a7-ab87-5835c58f5067"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cd39b9f6-43b2-48a2-b85b-c9418a598fa6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e4a1621c-15e4-4d8c-9b5c-eb05be65501e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e8a17c37-4dd4-427d-b681-4002019b347a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ebfed259-0c6f-4486-b2fe-dbf9edf1be7e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f7a0beb7-82c1-4d57-a784-d83235e63849"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fa8d5f83-b455-40c5-9fdc-33314b6ad664"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc4631f5-c6d3-462a-966e-cceafa83b687"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fd4bb0dd-7cba-4c12-8bbb-18f47320bc05"));

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
        }
    }
}
