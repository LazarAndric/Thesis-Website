using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class AddGenderforUserandproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "tblUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tblGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProductGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductGender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProductGender_tblGender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "tblGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblProductGender_tblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblUser_GenderId",
                table: "tblUser",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductGender_GenderId",
                table: "tblProductGender",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductGender_ProductId",
                table: "tblProductGender",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser",
                column: "GenderId",
                principalTable: "tblGender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser");

            migrationBuilder.DropTable(
                name: "tblProductGender");

            migrationBuilder.DropTable(
                name: "tblGender");

            migrationBuilder.DropIndex(
                name: "IX_tblUser_GenderId",
                table: "tblUser");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "tblUser");
        }
    }
}
