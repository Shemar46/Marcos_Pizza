using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class nullableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "be52e27b-81b0-4b68-b675-d180fa4ce8be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "fdfe132c-8346-4e65-b064-adc21fb3b9a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "d12fc3df-946c-4a7b-93e4-de7e9f0ac7e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "338ef885-1f84-4985-859f-33ff3c06f69d", "AQAAAAEAACcQAAAAEHSB7ZJaJkffTCNSqGWD3AxM21RYdMqMbWBN36u/PSMbifRQaOsrdsk2z1HGokKvmw==", "31c32f52-ffb1-4028-95cf-8d0a8e98c0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d23e0aac-0d8b-4893-841c-de8438561565", "AQAAAAEAACcQAAAAEEPX6urUiGrbk1NDtmrfne+BRgWQpzYcQYDAF0nwraGX42QSBoiCrB+Bzd7zqXlkFA==", "f754fe48-bf2f-44f5-b58e-c56cab4d23f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec291f06-bef1-4af5-b066-e00ea9bf0ee2", "AQAAAAEAACcQAAAAEGQO7xgch70pQDZp9oRkJ3yht0RDIN5SRN1Ap01TlJqICbbshx4t+VmjyTbll67UDw==", "465e2159-846d-4412-a8ad-1673e2592297" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b04b9df0-c89a-45a9-ad5a-2cdada5d036f", "AQAAAAEAACcQAAAAEBWLjKXv6m8r5vd8p7qXBuvE6WEBqZ4W5NIph2UaJlNpIKYF8dYfxjXpCM1jaDnWrw==", "991107f4-d03a-4ca5-a021-16511898cde0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
