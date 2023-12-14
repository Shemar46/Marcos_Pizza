using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class passwordchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "ecbe950b-85e2-4cde-805d-c5ea254a0c1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "071a9355-5adb-4a30-9848-f44d2a63d9f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "63ae1bbb-5cf5-4e17-a29f-e4cd9333f543");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5089323d-dac7-445e-97e4-ca7615e9bb16", "AQAAAAEAACcQAAAAEA5hv+vuL+3DOtWC5qvylFic5MvD7D2ch9xM1TBQn3+KcVMjotlhb9qr8cv9w/Gj+A==", "d8888e44-ff2e-4b09-b3f0-c569714db84d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95af6093-584a-4fa4-8e3a-e48fe73018df", "AQAAAAEAACcQAAAAEPVOUZR2SqLrmBUUifO0HwboVdvrywzyEB8mnmdBQ1f8aYMRzGKo8flWkJ2TCmZTwQ==", "f4b48de9-1ec7-48a9-92d7-53cb106b1cd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bcd2836-ebe6-465e-8819-d79cfdafcb5b", "AQAAAAEAACcQAAAAENTq3qwi/2zDQWGg++52E1/8rksx6qA7pgMmnYraSqaRc8RLK5AJUbpUw6RmNb4D6A==", "7849108a-08a8-4a1f-b120-633a40d3175e" });
        }
    }
}
