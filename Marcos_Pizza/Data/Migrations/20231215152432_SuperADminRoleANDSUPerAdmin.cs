using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class SuperADminRoleANDSUPerAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6a02c66-acf0-4fab-a98e-467080ee51df", "d6a02c66-abf0-4fab-a98e-468080ee51df" });

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4e166e1-363f-4f5e-a91d-b4b957c27cdc", "64551075-557c-4508-a4ae-132c9ee4aab7", "SuperAdmin", "SUPERADMIN" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4e166e1-363f-4f5e-a91d-b4b957c27cdc", "f4e155e1-363f-4f5e-a91d-a4a957c27cdc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4e166e1-363f-4f5e-a91d-b4b957c27cdc", "f4e155e1-363f-4f5e-a91d-a4a957c27cdc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e166e1-363f-4f5e-a91d-b4b957c27cdc");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6a02c66-acf0-4fab-a98e-467080ee51df", "d6a02c66-abf0-4fab-a98e-468080ee51df" });

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
    }
}
