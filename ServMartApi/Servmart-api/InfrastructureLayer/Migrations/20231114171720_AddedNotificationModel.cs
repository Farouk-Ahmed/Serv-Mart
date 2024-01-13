using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotificationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
