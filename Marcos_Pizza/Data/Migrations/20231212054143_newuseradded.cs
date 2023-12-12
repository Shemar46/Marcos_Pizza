using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class newuseradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be70bfbe-3812-4a37-b42d-66d9ed5baf5f", "be70bfbe-3812-5a37-b42d-66d9ed5baf7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc", "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-4a37-b42d-66d9ed5baf5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be70bfbe-3812-4b96-b42d-66d7ed5baf5f", "5f1c0784-a848-40de-9ac0-d0fceb519d55", "User", "USER" },
                    { "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca", "1a67f106-ea0f-4218-873e-29a021d54995", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8b43ka6-de6b-4a8e-949c-a5d14311c1cb", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-5a37-b42d-66d9ed5baf7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b1318a-c6c7-445d-81a3-dd8a2af480c8", "AQAAAAEAACcQAAAAEJv4jzZYxDCxlJvaQeJjkVtf/BkiXplfmac0vzAmOA4IDRKBCq0DAQ2S0DivW2OJ/A==", "7e95d647-a9ea-4417-85e6-a568fe917b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbd13817-93e4-49d7-ac1e-ca9820597955", "AQAAAAEAACcQAAAAECjlcIyG+J3X/TgQJyEnbWrBLtvE68wR9fqFeyyL+RQcE9rD3t03QxeQKBuLd8Mo/w==", "312ddb03-6829-4440-ac71-d6aa5f876d2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2abe094-d69a-467e-88cc-f2bd9d6d3484", "AQAAAAEAACcQAAAAEAWj6vk3xeL0jLOTOHaOL2JYVfdktEb9akKEqSGFmF/z8VD+0kRR1m5LiDJCjbJ92A==", "7351ccd3-e917-4a8b-8776-ea97ec03ac8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-4b96-b42d-66d7ed5baf5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8b43ka6-de6b-4a8e-949c-a5d14311c1cb", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be70bfbe-3812-4a37-b42d-66d9ed5baf5f", "dde7a6f3-a7a3-4a71-8fa0-e4aa66c7c15e", "User", "USER" },
                    { "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc", "c44bdfff-7710-4dbc-b98b-34b6f0255dd1", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-5a37-b42d-66d9ed5baf7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "712ab66d-0115-461b-9037-c521e99ff92d", "AQAAAAEAACcQAAAAEKeSJB0ixORkAMWpFX3TLdPpcJOGtSOB8hloFgfYZjS4XamlBDDPDYKsDupX/0cdhw==", "a32111fa-b1d4-4c88-bda8-583d641c451d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b20ae8bf-f920-4691-a70d-1e24faab28cd", "AQAAAAEAACcQAAAAEBjllyEFYbFYFUUkpMZaDKhKdmlzczmiFPRibtsCqmrKgXj8qEsNLYpZKgpXXGgTaw==", "679829b7-8ca5-4a42-ba50-6208619d60af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8877b9-6052-4477-ac14-09332e5eb82d", "AQAAAAEAACcQAAAAEGBM2z/08v2tMmgYIGwWG9MePeq7O2T5QmJaqJPOOquCpRWL2DlaNpRjv3GTV4aI6w==", "fb644f8a-41f0-4e3c-873d-f63897131039" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be70bfbe-3812-4a37-b42d-66d9ed5baf5f", "be70bfbe-3812-5a37-b42d-66d9ed5baf7e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc", "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca" });
        }
    }
}
