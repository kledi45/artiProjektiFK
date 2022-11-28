using Microsoft.EntityFrameworkCore.Migrations;

namespace Sneaker_Shop_Management.Migrations
{
    public partial class addDescToShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Shoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Shoes");
        }
    }
}
