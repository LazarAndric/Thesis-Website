using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class updateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct");

            migrationBuilder.DropIndex(
                name: "IX_tblProduct_ProductCategoryId",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "tblProduct");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "tblProduct",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_CategoryId",
                table: "tblProduct",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblCategory_CategoryId",
                table: "tblProduct",
                column: "CategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProduct_tblCategory_CategoryId",
                table: "tblProduct");

            migrationBuilder.DropIndex(
                name: "IX_tblProduct_CategoryId",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "tblProduct");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "tblProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ProductCategoryId",
                table: "tblProduct",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct",
                column: "ProductCategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
