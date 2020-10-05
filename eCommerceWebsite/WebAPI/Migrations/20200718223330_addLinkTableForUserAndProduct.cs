using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class addLinkTableForUserAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Sale",
                table: "tblProduct",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductsOfUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    DateOfProductPurchased = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOfUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsOfUsers_tblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOfUsers_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOfUsers_ProductId",
                table: "ProductsOfUsers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOfUsers_UserId",
                table: "ProductsOfUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOfUsers");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "tblProduct");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
