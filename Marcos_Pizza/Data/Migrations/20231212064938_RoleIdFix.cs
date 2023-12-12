using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class RoleIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-4b96-b42d-66d7ed5baf5f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8b43ka6-de6b-4a8e-949c-a5d14311c1cb", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca",
                column: "ConcurrencyStamp",
                value: "01270698-dadc-4b3b-ad18-a598038b903c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be70bfb6-3812-4b96-b42d-66d7ed5baf5f", "28900970-b76a-4ab6-b1e4-426f77e0e8dc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca", "e9b43bb8-ad2c-4a8e-949c-a4d14313c1cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-5a37-b42d-66d9ed5baf7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f659841-2095-43c3-88d0-ba9b2456f93b", "AQAAAAEAACcQAAAAEAXM4Ed8kYrEKTbeGHpSRjSgBjvdOGvR25D1lEjgyvpfCQK5Qp71Y1xGfgMyDRyeWg==", "0e47f188-c030-4cc6-a647-d3d98df96e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d6bc4ab-0932-4613-8b66-71b4e3fc7b58", "AQAAAAEAACcQAAAAEGXHHj7f7VtoKKieWLFZM0Xr47r+M9EopQfVGpJ+3vRr2889dLJCgEYcRtEfnbenAA==", "984e2e9d-8ec4-418c-b691-eeff01cde55a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f3a4e8-d94b-4144-8b64-32879ee13a95", "AQAAAAEAACcQAAAAEOvbRXLnadPhDo1lKdP44vGir0w1gZElC77OMZTN3Kj7LxzKhPVChJUzw7qg5ZG3lw==", "deee7faf-397b-4832-aadd-e3f8078e37ee" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be70bfb6-3812-4b96-b42d-66d7ed5baf5f", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be70bfb6-3812-4b96-b42d-66d7ed5baf5f", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca", "e9b43bb8-ad2c-4a8e-949c-a4d14313c1cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfb6-3812-4b96-b42d-66d7ed5baf5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca",
                column: "ConcurrencyStamp",
                value: "1a67f106-ea0f-4218-873e-29a021d54995");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be70bfbe-3812-4b96-b42d-66d7ed5baf5f", "5f1c0784-a848-40de-9ac0-d0fceb519d55", "User", "USER" });

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
    }
}
