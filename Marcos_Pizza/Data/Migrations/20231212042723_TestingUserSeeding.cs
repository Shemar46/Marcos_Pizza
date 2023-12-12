using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class TestingUserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-4a37-b42d-66d9ed5baf5f",
                column: "ConcurrencyStamp",
                value: "dde7a6f3-a7a3-4a71-8fa0-e4aa66c7c15e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc",
                column: "ConcurrencyStamp",
                value: "c44bdfff-7710-4dbc-b98b-34b6f0255dd1");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b20ae8bf-f920-4691-a70d-1e24faab28cd", "AQAAAAEAACcQAAAAEBjllyEFYbFYFUUkpMZaDKhKdmlzczmiFPRibtsCqmrKgXj8qEsNLYpZKgpXXGgTaw==", "679829b7-8ca5-4a42-ba50-6208619d60af", "admin1@yahoo.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[] { "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca", 0, "1e8877b9-6052-4477-ac14-09332e5eb82d", "admin123@yahoo.com", true, "user123", "Admin123", false, null, "ADMIN123@YAHOO.COM", null, "AQAAAAEAACcQAAAAEGBM2z/08v2tMmgYIGwWG9MePeq7O2T5QmJaqJPOOquCpRWL2DlaNpRjv3GTV4aI6w==", null, false, "fb644f8a-41f0-4e3c-873d-f63897131039", false, "admin123@yahoo.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-4a37-b42d-66d9ed5baf5f",
                column: "ConcurrencyStamp",
                value: "c6b25f56-6a87-4edd-be24-5e8aaedebc2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc",
                column: "ConcurrencyStamp",
                value: "dce754c0-b891-416b-ad6f-df114100726e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-5a37-b42d-66d9ed5baf7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "305cf580-496e-48ec-9f64-4ab1a33482a9", "AQAAAAEAACcQAAAAEDKHzB82/gIHeyzC+ViJOMLR9KFY45WU65z4fQHP3ps9RSXCC17+RF4SpIk/OS4u7A==", "587f7241-37d8-4ffa-b03c-6c3db7bd9c48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4923a200-fd72-47d2-a6c2-b4a751df67e0", "AQAAAAEAACcQAAAAEDjCuXm6Pa1bzkDOS2yqrwD8Abe1caQpzN88jpIPsw0csvT8fY7Xruw7LBoTBo40vA==", "918ed4fb-0fa6-4540-b12b-67c4de7d1061", "admin@yahoo.com" });
        }
    }
}
