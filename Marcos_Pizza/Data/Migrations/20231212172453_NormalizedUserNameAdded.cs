using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class NormalizedUserNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "3bb20a97-c00a-4bd7-86e1-66b2644e1f00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "ae6f8f78-eb93-4725-8a72-3fc442043f3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "b0f2244b-6f7b-45b6-afd3-34d361cc053b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec8c2b6-f16d-4409-94b4-da39fd2d2a30", "ADMIN1@YAHOO.COM", "AQAAAAEAACcQAAAAEKVbolhIpz2o7TeSnucdEHVmiZXOnDeRCl2UWEc4B1jCWzlRfjtivy6rzg9gi6KNtQ==", "d75885a4-c93c-4eed-9bcd-d117a14559da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26c8a38-8f0c-4662-84a0-1a29861a4828", "ADMIN1@HOO.COM", "AQAAAAEAACcQAAAAELEBnMtx2w78r6lGbj5PRuYZfhy09NvKbpFFXNaZJBv9Ia/FWB657VpqAzvw8kAk8g==", "057a1418-07be-4b49-b4b8-4544ef31bc7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f3c231-8795-4ce3-aa7b-de52ba3fbd68", "MAR@USER.COM", "AQAAAAEAACcQAAAAEOz8v30jvNE/UghXuM5Kc94eyjGl+/fTm7cEM7W60TZTBucHOZS3tgbxVX1q6ky5vw==", "10672137-f9bb-4a35-b759-20c596d066fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79bffdf0-07b9-41d4-8762-25ca877ea695", "ADMIN1@YAH.COM", "AQAAAAEAACcQAAAAEPbToHNm21ur294cjufAxCkQ+1PYw4nhzpdPg8xi8EbVjZwqwx8nIrge1J+aPWnQWg==", "a5eda566-a4d1-4b0f-a9f6-e0eea571fc43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "6037c958-a82d-4251-9911-ff4ede5ee109");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "ac20a385-25aa-4b8f-b8cc-84e472ec9579");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "c8ad33b2-702e-4b6f-9eae-fd9e67b82a84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439faafb-eeb3-42e9-b411-74a846b07979", null, "AQAAAAEAACcQAAAAEHfP2ob3gc4/84XHSZHlK4OH0Sl60BxB5jvVTVFgJvR4Iph6Nu9ay1Gs8KcSovxWNA==", "10ee492d-6c0a-4721-a764-aeee4b1cb7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81fefd90-54df-4f1c-8c43-294d3965468c", null, "AQAAAAEAACcQAAAAEDtUL+OOgSwdau2SjBjFpf0jUoXtxTcsSdCMVDMklGlDINDwW5DQ5CPsGvIV/l8Ztg==", "877be329-13aa-4fb5-bd84-a9945374ff89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae9f3b6-551e-42e4-adbf-fed7887055fb", null, "AQAAAAEAACcQAAAAEKmh7r4lXg+tZ0Yje52pXCDMapcB7yBGnV9Diznj6FEt0L1MO+PZk8Yxcjgb2hvs8w==", "c3f08e87-47db-433f-9a69-f0bdd82e997b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7dd57f0-8500-4be7-b212-c75311f60923", null, "AQAAAAEAACcQAAAAEHXhdMt3Kx63O3cjDni3456/m2DD8byc8HWdThOekz+VqCSyfAHaZb0Nu6PLdpie6g==", "7ac1eae8-d13f-47fb-8525-3ca3e51287bf" });
        }
    }
}
