using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class ProducAndPaymentDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "960ecde4-5c2e-40de-8454-8641f92b12f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "7be779dc-d3fa-402f-9816-4b2ca40118b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "35c1969b-b77b-4d40-9cba-f23070cded4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf142485-cb7c-4d1d-bd3c-197b5fcb40ad", "AQAAAAEAACcQAAAAEBJvgYEcGQ4OHLXRK6mmcKHQa8fRtNP5+ZsBe+SHdV/U6HKEcu8r7Y39ZMwqAOScsQ==", "41c7f4d7-0823-4847-837b-dd1e3ebbeea3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4b8c99-d1bb-48ee-a534-4af4cc25c135", "AQAAAAEAACcQAAAAEGscvVaGK+eUoy5nG0wDNY9uZhHqYSEGBpBCzAR+6VASaVpP8RkR/MhyKyqu7naUVg==", "5c2680ff-fe5b-4789-97c0-f3047a1f40f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d42b759-707e-49f2-a694-36db3c438a1d", "AQAAAAEAACcQAAAAEFwh3bgNlXoHWN0Ev/uC3Qqa2hyvNZhXB69wHq315oYnVF9GpjgcZvsuADrSQuxk1g==", "2eae5742-a318-4ffc-bada-d5e9ef47dc21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddb4e651-4ab5-40bc-8d1e-8541d06a96c8", "AQAAAAEAACcQAAAAEAySrL3+2X5IcxlSEGyp6TMF3shI0IgAQjISJ5Hgdd8opzKv+zNrsxLa9q6MowIaeA==", "71d5d4e7-a555-4e8e-8297-df70fea798cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
