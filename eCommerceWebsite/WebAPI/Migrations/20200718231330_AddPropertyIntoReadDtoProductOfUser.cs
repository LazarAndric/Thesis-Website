using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class AddPropertyIntoReadDtoProductOfUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfUsers_tblProduct_ProductId",
                table: "ProductsOfUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfUsers_tblUser_UserId",
                table: "ProductsOfUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfUsers",
                table: "ProductsOfUsers");

            migrationBuilder.RenameTable(
                name: "ProductsOfUsers",
                newName: "tblUserProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfUsers_UserId",
                table: "tblUserProduct",
                newName: "IX_tblUserProduct_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfUsers_ProductId",
                table: "tblUserProduct",
                newName: "IX_tblUserProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblUserProduct",
                table: "tblUserProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblUserProduct_tblProduct_ProductId",
                table: "tblUserProduct",
                column: "ProductId",
                principalTable: "tblProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblUserProduct_tblUser_UserId",
                table: "tblUserProduct",
                column: "UserId",
                principalTable: "tblUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblUserProduct_tblProduct_ProductId",
                table: "tblUserProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_tblUserProduct_tblUser_UserId",
                table: "tblUserProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblUserProduct",
                table: "tblUserProduct");

            migrationBuilder.RenameTable(
                name: "tblUserProduct",
                newName: "ProductsOfUsers");

            migrationBuilder.RenameIndex(
                name: "IX_tblUserProduct_UserId",
                table: "ProductsOfUsers",
                newName: "IX_ProductsOfUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tblUserProduct_ProductId",
                table: "ProductsOfUsers",
                newName: "IX_ProductsOfUsers_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfUsers",
                table: "ProductsOfUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfUsers_tblProduct_ProductId",
                table: "ProductsOfUsers",
                column: "ProductId",
                principalTable: "tblProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfUsers_tblUser_UserId",
                table: "ProductsOfUsers",
                column: "UserId",
                principalTable: "tblUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
