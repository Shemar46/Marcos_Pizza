using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class testuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439faafb-eeb3-42e9-b411-74a846b07979", "AQAAAAEAACcQAAAAEHfP2ob3gc4/84XHSZHlK4OH0Sl60BxB5jvVTVFgJvR4Iph6Nu9ay1Gs8KcSovxWNA==", "10ee492d-6c0a-4721-a764-aeee4b1cb7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae9f3b6-551e-42e4-adbf-fed7887055fb", "AQAAAAEAACcQAAAAEKmh7r4lXg+tZ0Yje52pXCDMapcB7yBGnV9Diznj6FEt0L1MO+PZk8Yxcjgb2hvs8w==", "c3f08e87-47db-433f-9a69-f0bdd82e997b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7dd57f0-8500-4be7-b212-c75311f60923", "AQAAAAEAACcQAAAAEHXhdMt3Kx63O3cjDni3456/m2DD8byc8HWdThOekz+VqCSyfAHaZb0Nu6PLdpie6g==", "7ac1eae8-d13f-47fb-8525-3ca3e51287bf" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[] { "63cb8c98-1927-46b6-aa72-d2e7bc12cf49", 0, "81fefd90-54df-4f1c-8c43-294d3965468c", "admin1@hoo.com", true, "user", "Admin", false, null, "ADMIN1@HOO.COM", null, "AQAAAAEAACcQAAAAEDtUL+OOgSwdau2SjBjFpf0jUoXtxTcsSdCMVDMklGlDINDwW5DQ5CPsGvIV/l8Ztg==", null, false, "877be329-13aa-4fb5-bd84-a9945374ff89", false, "admin1@hoo.com", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c6a02c66-bbf0-4fab-a98e-468181ee51de", "63cb8c98-1927-46b6-aa72-d2e7bc12cf49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6a02c66-bbf0-4fab-a98e-468181ee51de", "63cb8c98-1927-46b6-aa72-d2e7bc12cf49" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "497db1ac-681f-4654-b6c3-7dee40bd9896");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "f92a197b-47cd-40f5-bf07-bcf906c02063");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "65624676-d068-4234-a7f7-65f2e8142c77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "794485e3-3d42-47e3-8649-8680c264e200", "AQAAAAEAACcQAAAAECTgUyVc8K0nTgou1tM9qP+LSxFywHjIFxi1uSfvhBylUoMqMxfEmlc33Rzl+svlVg==", "789a40c8-bc4a-43e1-b6d5-01df6e2cae40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9763da5d-a109-45a2-a322-3cf97baeae50", "AQAAAAEAACcQAAAAEFFXTTLK/kWo8mcF+DxGcuk9VFypBQnqiBend5VQC04eTQsbCnsH3ly1fOuVuAUOlA==", "26bd962c-037d-4d8d-bea7-07a732e42d2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ef2e0dd-5ed4-4536-ac4b-1b159b5ceae1", "AQAAAAEAACcQAAAAEKFtdzjkMU0ZPjQMrLmsxDbLVcajXVTT8pJQrsbtGooPRxEFBRRfGYRmxquUmNJHXQ==", "b79b85e4-0cad-40eb-bbf8-12d545bafee6" });
        }
    }
}
