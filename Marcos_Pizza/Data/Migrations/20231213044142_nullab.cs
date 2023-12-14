using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class nullab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Product_IMG",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Product_Code",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "f322d3d9-4139-48d0-a281-d618984a924c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "fc52503a-99eb-4541-b46d-1e786d17cf49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "a3babf0d-c6a2-44cf-bdd1-7245d3b4a9d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dc95b12-2ce5-4a64-96e0-86c2c7ad0217", "AQAAAAEAACcQAAAAENGPS4dLLwk1clN1nzhRKvhfksckEncDbQw+1VscF0TChdlXYxV9iVkotM2cj8euPw==", "5bbafac7-783a-4c65-891d-90c2f9f4f475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf16562f-acfd-43f4-b741-97d34e101f79", "AQAAAAEAACcQAAAAEMHj7QaG5FrarGeF6Gbos3EkbV3YYH7oX4Qs9mw95tZ9jIJdQmegZGncc1zVO4wo9w==", "c9fae3dd-55bc-4767-a3fe-1912b234522c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f189cfcc-2839-4e46-8913-1a5e439fed66", "AQAAAAEAACcQAAAAEL1VOTC9cKml/HvMuryQ8gvwYkgv18eihts+W3/RPnbADm2tz4PUqcNQIAeTJ298IQ==", "e3726052-82ba-482c-831a-5f06164f9f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c99f50e0-cedc-436a-845e-f44644e46e26", "AQAAAAEAACcQAAAAEOLEprcdf6tUqMCphEXyJNLr0BxKKJJtr76qDzBLPv87pdrEPZU0nuLMZZLGyNptKw==", "3133ba91-a15a-4708-9ef3-478e34926252" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Product_IMG",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Product_Code",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec8c2b6-f16d-4409-94b4-da39fd2d2a30", "AQAAAAEAACcQAAAAEKVbolhIpz2o7TeSnucdEHVmiZXOnDeRCl2UWEc4B1jCWzlRfjtivy6rzg9gi6KNtQ==", "d75885a4-c93c-4eed-9bcd-d117a14559da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26c8a38-8f0c-4662-84a0-1a29861a4828", "AQAAAAEAACcQAAAAELEBnMtx2w78r6lGbj5PRuYZfhy09NvKbpFFXNaZJBv9Ia/FWB657VpqAzvw8kAk8g==", "057a1418-07be-4b49-b4b8-4544ef31bc7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f3c231-8795-4ce3-aa7b-de52ba3fbd68", "AQAAAAEAACcQAAAAEOz8v30jvNE/UghXuM5Kc94eyjGl+/fTm7cEM7W60TZTBucHOZS3tgbxVX1q6ky5vw==", "10672137-f9bb-4a35-b759-20c596d066fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79bffdf0-07b9-41d4-8762-25ca877ea695", "AQAAAAEAACcQAAAAEPbToHNm21ur294cjufAxCkQ+1PYw4nhzpdPg8xi8EbVjZwqwx8nIrge1J+aPWnQWg==", "a5eda566-a4d1-4b0f-a9f6-e0eea571fc43" });
        }
    }
}
