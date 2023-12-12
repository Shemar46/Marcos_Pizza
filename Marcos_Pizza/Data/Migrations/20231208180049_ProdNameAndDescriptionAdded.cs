using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    public partial class ProdNameAndDescriptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Product_Description",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Description",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "Orders");
        }
    }
}
