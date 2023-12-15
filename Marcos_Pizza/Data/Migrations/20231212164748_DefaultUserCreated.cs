using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class DefaultUserCreated : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43cb8c89-9172-46b6-aa72-e2e7dc12cf49", "ecbe950b-85e2-4cde-805d-c5ea254a0c1c", "Administrator", "ADMINISTRATOR" },
                    { "b6a02c66-acf0-4fab-a98e-467080ee51df", "071a9355-5adb-4a30-9848-f44d2a63d9f1", "User", "USER" },
                    { "c6a02c66-bbf0-4fab-a98e-468181ee51de", "63ae1bbb-5cf5-4e17-a29f-e4cd9333f543", "System", "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[,]
                {
                    { "43cb8c89-9172-46b6-aa72-f2e7bc12cf49", 0, "5089323d-dac7-445e-97e4-ca7615e9bb16", "admin1@yahoo.com", true, "user", "Admin", false, null, "ADMIN1@YAHOO.COM", null, "AQAAAAEAACcQAAAAEA5hv+vuL+3DOtWC5qvylFic5MvD7D2ch9xM1TBQn3+KcVMjotlhb9qr8cv9w/Gj+A==", null, false, "d8888e44-ff2e-4b09-b3f0-c569714db84d", false, "admin1@yahoo.com", null },
                    { "d6a02c66-abf0-4fab-a98e-468080ee51df", 0, "95af6093-584a-4fa4-8e3a-e48fe73018df", "mar@user.com", true, "Mar", "user", false, null, "MAR@USER.COM", null, "AQAAAAEAACcQAAAAEPVOUZR2SqLrmBUUifO0HwboVdvrywzyEB8mnmdBQ1f8aYMRzGKo8flWkJ2TCmZTwQ==", null, false, "f4b48de9-1ec7-48a9-92d7-53cb106b1cd6", false, "mar@user.com", null },
                    { "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca", 0, "2bcd2836-ebe6-465e-8819-d79cfdafcb5b", "admin1@yah.com", true, "user", "Admin", false, null, "ADMIN1@YAH.COM", null, "AQAAAAEAACcQAAAAENTq3qwi/2zDQWGg++52E1/8rksx6qA7pgMmnYraSqaRc8RLK5AJUbpUw6RmNb4D6A==", null, false, "7849108a-08a8-4a1f-b120-633a40d3175e", false, "admin1@yah.com", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43cb8c89-9172-46b6-aa72-e2e7dc12cf49", "43cb8c89-9172-46b6-aa72-f2e7bc12cf49" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6a02c66-acf0-4fab-a98e-467080ee51df", "d6a02c66-abf0-4fab-a98e-468080ee51df" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c6a02c66-bbf0-4fab-a98e-468181ee51de", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43cb8c89-9172-46b6-aa72-e2e7dc12cf49", "43cb8c89-9172-46b6-aa72-f2e7bc12cf49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6a02c66-acf0-4fab-a98e-467080ee51df", "d6a02c66-abf0-4fab-a98e-468080ee51df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6a02c66-bbf0-4fab-a98e-468181ee51de", "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-e2e7dc12cf49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a02c66-acf0-4fab-a98e-467080ee51df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a02c66-bbf0-4fab-a98e-468181ee51de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43cb8c89-9172-46b6-aa72-f2e7bc12cf49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a02c66-abf0-4fab-a98e-468080ee51df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca");
        }
    }
}
