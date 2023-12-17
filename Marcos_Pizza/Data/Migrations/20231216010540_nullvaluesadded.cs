using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class nullvaluesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "1da4fbbc-636e-459d-aae6-cfa8b18a567d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "48fa7da9-3c9d-41c8-a143-bfb84f6b1dc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "716c247f-732b-40a9-9d5b-28701acca033");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                column: "ConcurrencyStamp",
                value: "ad29b359-cb89-4bad-94a3-6ba945c6756f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b40614c9-31a9-4383-b998-ff9dbdb4434e", "AQAAAAEAACcQAAAAEII+1e2kOVUmxv/dBRqXcUGIN8PvMGcwInnxK1+QHAmVnzxNEAU5QYxkHMsnTwVY5Q==", "c7a1f2cb-c271-4511-997c-c00c48eed5ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e98bb2b6-3e3b-445b-b15d-a0c853d99378", "AQAAAAEAACcQAAAAENRavV/LXXwD8x3krf3ZAlXhpYNRUx+ZpGakRkKSGPDRuZXygJu4KsUi7q3zTEbGOg==", "a2912f89-d12b-471e-8b7d-97e795eb86d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba8d3c9-028b-4b5f-aeeb-675abd57dc03", "AQAAAAEAACcQAAAAEMuWa4Y9eoGs4/t8Cx+WqOTg76x3ZyfzdrV3IdGdBJV3TgOfZMCl6PmFaYbcQMKkmw==", "47568f0f-013e-4a1f-8ba0-61d422d6d9df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ececefed-3bf6-4c08-a162-b70d6bf298c6", "AQAAAAEAACcQAAAAEMMEyo1PhDKeRqhDHGFLCgXhnfJ3ku0IHuV2IjLxAJbey/RV/1I+SwzEisAcTBIkUQ==", "e3b7ecac-3cca-4674-9a02-4b9acde71231" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
