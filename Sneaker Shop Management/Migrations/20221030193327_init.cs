using Microsoft.EntityFrameworkCore.Migrations;

namespace Sneaker_Shop_Management.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NewsLetter_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    BuyPrice = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Size = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shoes_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdShoes = table.Column<int>(nullable: true),
                    Type1 = table.Column<int>(nullable: false),
                    Type2 = table.Column<int>(nullable: false),
                    Type3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeliveryType_Shoes_IdShoes",
                        column: x => x.IdShoes,
                        principalTable: "Shoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sell",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdShoes = table.Column<int>(nullable: true),
                    IdUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sell", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sell_Shoes_IdShoes",
                        column: x => x.IdShoes,
                        principalTable: "Shoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sell_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSell = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bid_Sell_IdSell",
                        column: x => x.IdSell,
                        principalTable: "Sell",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_IdSell",
                table: "Bid",
                column: "IdSell");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryType_IdShoes",
                table: "DeliveryType",
                column: "IdShoes");

            migrationBuilder.CreateIndex(
                name: "IX_NewsLetter_IdUser",
                table: "NewsLetter",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Sell_IdShoes",
                table: "Sell",
                column: "IdShoes");

            migrationBuilder.CreateIndex(
                name: "IX_Sell_IdUser",
                table: "Sell",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_UserId",
                table: "Shoes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid");

            migrationBuilder.DropTable(
                name: "DeliveryType");

            migrationBuilder.DropTable(
                name: "NewsLetter");

            migrationBuilder.DropTable(
                name: "Sell");

            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
