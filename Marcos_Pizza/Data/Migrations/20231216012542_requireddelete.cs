using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class requireddelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Customer_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cashier",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                column: "ConcurrencyStamp",
                value: "8fa3d92b-7823-4f27-8ba1-d6a23f67f7b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df",
                column: "ConcurrencyStamp",
                value: "aeb92d5d-566f-4ee9-a08b-840200cfb8d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                column: "ConcurrencyStamp",
                value: "22d3e409-2180-48d5-baa5-5ad0b7e3a0f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                column: "ConcurrencyStamp",
                value: "63479da7-a37c-4d90-83a7-732d4e04a899");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ae24d5d-b20f-4d2b-aaec-cad1fcb73174", "AQAAAAEAACcQAAAAELaFAC5qKJtOxn2Smwz9FyhCLJeySZkMiPDJ5x/MFSp8xKTUFitVCMONZXqu32BMrg==", "80d0bd77-4545-4f35-be5a-66306376d495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d616b22d-610b-498b-844d-8e43eb9bf588", "AQAAAAEAACcQAAAAEGrI0IjasqxsY+FoEADlwWIrJIrpkMa47Dvtsn/0De5B2idnbdrUePAErhW7mHSBlQ==", "6c625aaa-8f54-4bb9-804e-89cc6db11f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea3def7b-863b-47ab-af70-05f8a16e3f01", "AQAAAAEAACcQAAAAEHflUs+S2ArF/tl8SCD1usl7Ua8GOBbAfP0OxrunJ3vQYHW2taVK54lzC7kF7CpVYA==", "e3deca15-7205-4bfc-a779-0cef72ee41b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea443493-8702-400c-9287-b9a2f5077a82", "AQAAAAEAACcQAAAAEMnVZhPM6pUjM1ZGKkLQeHYKqEh6qBsCtjjACa2zIQZedd+yT5GhKimoHaWBCYkGeg==", "0c310611-b407-4518-88a5-8bb7b951deb1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Customer_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cashier",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
