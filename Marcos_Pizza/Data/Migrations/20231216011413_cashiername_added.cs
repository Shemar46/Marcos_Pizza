using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class cashiername_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cashier",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "1d6290d5-65b6-4fd7-83b4-702f6baa49ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "d5fe497c-d541-46d1-9829-01da8bf3833a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "5e6c0234-ecbf-4ab8-8934-ea5e8c4dd834");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                column: "ConcurrencyStamp",
                value: "a2be237b-cb8f-424d-a56c-aaa9a39035e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad08396f-0af8-4264-ab92-045b2a024807", "AQAAAAEAACcQAAAAELHYPdKIu3PWqFvuJB9gqippzbXV2JQcM2twmZmWLF3Amh82+CZ0Ml3nzbv8cNkDXA==", "e41490f5-cf2b-49ec-baf5-bc43ae28dc9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41e38cf3-537c-4235-8f09-89b4eb0ea320", "AQAAAAEAACcQAAAAEMvlTk64it3i4pRdMXwjRIBfr0oCaBWqufkI49cO49S67y5nU52n1H2+ki/oA8MRwg==", "1e600cfc-5827-4e46-8435-69e9dbb91e43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c695255b-dbcd-4890-9062-bf0c4ff340e6", "AQAAAAEAACcQAAAAENgqXDPyKuzYwVsEDTFAn+V+LQAIf+7IG8imgP167Qg5Oeq63HaNs/kP/TwcVyZ/OQ==", "601dbfe2-d95e-4405-9ae5-a4bcc7926f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c685462c-cac9-4514-ae2d-e35e08bb35af", "AQAAAAEAACcQAAAAEOfQi5XP85b9hbEBqA8H86YWIQok75YYZIMmT3pQrVJLrVUea6agzwesw8HDkeRMpg==", "daf92511-c73a-4f6f-bc1c-e3a3353e5cc7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cashier",
                table: "Orders");

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
    }
}
