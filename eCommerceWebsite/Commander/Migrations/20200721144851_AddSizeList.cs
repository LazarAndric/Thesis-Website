using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class AddSizeList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfProductPurchased",
                table: "tblUserProduct",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLogin",
                table: "tblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRegistration",
                table: "tblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "tblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreate",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "tblSize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSize_tblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblSize_ProductId",
                table: "tblSize",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSize");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfProductPurchased",
                table: "tblUserProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastLogin",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DateOfRegistration",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DateOfCreate",
                table: "tblProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
