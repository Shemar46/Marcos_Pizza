using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class UserAndRoleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be70bfbe-3812-4a37-b42d-66d9ed5baf5f", "c6b25f56-6a87-4edd-be24-5e8aaedebc2a", "User", "USER" },
                    { "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc", "dce754c0-b891-416b-ad6f-df114100726e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[,]
                {
                    { "be70bfbe-3812-5a37-b42d-66d9ed5baf7e", 0, "305cf580-496e-48ec-9f64-4ab1a33482a9", "mar@user.com", true, "Mar", "user", false, null, "MAR@USER.COM", null, "AQAAAAEAACcQAAAAEDKHzB82/gIHeyzC+ViJOMLR9KFY45WU65z4fQHP3ps9RSXCC17+RF4SpIk/OS4u7A==", null, false, "587f7241-37d8-4ffa-b03c-6c3db7bd9c48", false, "mar@user.com", null },
                    { "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca", 0, "4923a200-fd72-47d2-a6c2-b4a751df67e0", "admin1@yahoo.com", true, "user", "Admin", false, null, "ADMIN1@YAHOO.COM", null, "AQAAAAEAACcQAAAAEDjCuXm6Pa1bzkDOS2yqrwD8Abe1caQpzN88jpIPsw0csvT8fY7Xruw7LBoTBo40vA==", null, false, "918ed4fb-0fa6-4540-b12b-67c4de7d1061", false, "admin@yahoo.com", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be70bfbe-3812-4a37-b42d-66d9ed5baf5f", "be70bfbe-3812-5a37-b42d-66d9ed5baf7e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9b43ab6-ab3d-4a7a-949c-a4d14312d1cc", "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be70bfbe-3812-5a37-b42d-66d9ed5baf7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca");
        }
    }
}
