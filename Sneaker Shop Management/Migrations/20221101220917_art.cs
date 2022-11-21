using Microsoft.EntityFrameworkCore.Migrations;

namespace Sneaker_Shop_Management.Migrations
{
    public partial class art : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BidPrice",
                table: "Shoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidPrice",
                table: "Shoes");
        }
    }
}
