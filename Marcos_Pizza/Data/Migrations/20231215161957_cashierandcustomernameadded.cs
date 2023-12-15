using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class cashierandcustomernameadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Customer_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "378e8dd4-1540-411d-b8f3-8821dd2ae07f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "0018a775-48cb-492e-9d1f-4afd4de50887");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "9d4fb090-2366-4af5-83a3-c4f27f7d664b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                column: "ConcurrencyStamp",
                value: "42ef0a8f-089e-4994-add2-8e951392af98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49397af-dde7-4472-b084-ad089b3e665a", "AQAAAAEAACcQAAAAELhE3wCu1qAjh1YBhKUoCcj/PkOrVn9B9liD2/+V8OZYQitb9l5DVhKq8kaDfkwW8w==", "a1311390-ffa1-4737-9996-ae1111cd1e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "753b2e4b-497a-4421-a8f1-12936e0e54df", "AQAAAAEAACcQAAAAEL+09qdKOS/UfUTS7ABry9Ag6wLtag8BAgu4tooQW3NKrMEX6xSWOPRuK7YZA8MFrg==", "ece25468-4d16-4c0d-9f3e-d598d7d686d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f14e0a-e5c0-49f0-af2d-298b7bcb8ef9", "AQAAAAEAACcQAAAAEFooisH9+t9A9Fa7finIcTjIw4Eq5OKKGYVr5zAxdCgrS8y54W4tkTiZsDa9RavbrQ==", "e9490552-5915-4ed1-913b-047c66530a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8368c828-3886-4333-9c7c-a863dae589ca", "AQAAAAEAACcQAAAAECT1s+gXqIzmcHy4hGMmoTYaPdr7J/IyoH13RZHGZ35LFThvWKgjcOq/J0b3Ch6Pww==", "be99f890-1b5c-4a2b-9ecc-284e78793176" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_Name",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "7e232e5d-25b7-444a-a4a3-2b3fa1d3c6e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "5266fa12-95ff-49f5-82e6-22eceaae740a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "bdc803a1-d6cb-4992-b406-79e733004679");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                column: "ConcurrencyStamp",
                value: "64551075-557c-4508-a4ae-132c9ee4aab7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad77c664-2dc5-4913-b16c-44447de984f5", "AQAAAAEAACcQAAAAEH402eJ0shA/jLye8Cd+vTKUs08DIx6qBjP4wSdf9J0WKibEufr8s6/hYO98d7FD6Q==", "ee752eb2-dd8b-4bac-af02-20804f4b07a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d7216d-14c3-4a88-8ce0-488771dfeca9", "AQAAAAEAACcQAAAAELFatqzVvlRR5Hcj1AU6Mx31gdL3Rm6qelcGNqq94eT4858xFUDF6pQCFovPCTJZmQ==", "8b2cd866-7b75-4e24-aec1-6d696086bafe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e45db95-3e1a-4194-b2c1-189b885e804b", "AQAAAAEAACcQAAAAEDJpj0BLhjco92WZ7hkQIqfJ05FfyefyFRg1NmMMAIZl70ru8lk/9J0qkewoMG/4/Q==", "2c0812cc-bca1-4f39-a43d-c30d32feb7fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a0568a6-3a4f-4a69-b394-81992ed46592", "AQAAAAEAACcQAAAAEBNBGLaUW0DU0Hr6DRRM2WmfSIBkhMGOGauzcP9SMt+ss5sRyT2SpkRNaqrgvUf62Q==", "03348e13-5590-488c-bafe-92a34270624d" });
        }
    }
}
